
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using ogrenciSistemi_Data.Data;
using ogrenciSistemi_Data.Data.Repository;
using ogrenciSistemi_Data.Data.Repository.IRepository;
using ogrenciSistemi_Data.Repository.IRepository;
using ogrenciSistemi_Models;
using ogrenciSistemi_Models.ViewModels;
using ogrenciSistemi_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ogrenciSistemi_Data.Data.Repository
{
    public class OkullarRepository : Repository<Okul>, IOkullarRepository
    {

        private readonly ApplicationDbContext _db;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ISinifDersRepository _sinifDersRepo;
        private readonly IAppUserRepository _appUserRepo;
        public OkullarRepository(ApplicationDbContext db,
                                 UserManager<IdentityUser> userManager,
                                 IAppUserRepository appUserRepo,
                                 ISinifDersRepository sinifDersRepo) : base(db)
        {
            _db = db;
            _userManager = userManager;
            _appUserRepo = appUserRepo;
            _sinifDersRepo = sinifDersRepo;
        }


        public IEnumerable<SelectListItem> GetManagerList()
        {

            var managersList = _userManager.GetUsersInRoleAsync(WebConst.ManagerRole).GetAwaiter().GetResult();
            List<string> manager = new List<string>();
            return managersList.Select(i => new SelectListItem()
            {
                Text = _appUserRepo.FirstOrDefault(x => x.Email == i.Email).adSoyad,
                Value = i.Id
            });

        }
        public IEnumerable<SelectListItem> GetAllDropdownListOkul(bool isAdmin, string userId)
        {
            if (isAdmin)
            {
                return _db.Okul.Select(i => new SelectListItem()
                {
                    Text = i.OkulAd,
                    Value = i.Id.ToString()
                });
            }
            else
            {

                IList<SelectListItem> okulList = new List<SelectListItem>();
                IEnumerable<SelectListItem> managers = this.GetManagerList();
                // Giren Kullanıcının Müdür mü öğretmen mi olmasına karşılık listelenecek okullar kontrolü
                if (managers.Where(x => x.Value == userId).Count() == 0)
                {

                    // Öğretmenin Siniflara Kayıtlı Olduğu Okulların Çekilmesi
                    var ogretmenSinif = _sinifDersRepo.GetAll(x => x.OgretmenId == userId, includeProperties: "Siniflar").GroupBy(x => x.Siniflar.OkulId).Select(x => x.First());
                    foreach (var item in ogretmenSinif)
                    {
                        okulList.Add(_db.Okul.Where(x => x.Id == item.Siniflar.OkulId).Select(i => new SelectListItem
                        {
                            Text = i.OkulAd,
                            Value = i.Id.ToString()
                        }).FirstOrDefault());
                    }
                    return okulList;
                }
                else
                {
                    return _db.Okul.Where(x => x.ManagerId == userId).Select(i => new SelectListItem
                    {
                        Text = i.OkulAd,
                        Value = i.Id.ToString()
                    });
                }
            }
        }


        public void Update(Okul obj)
        {
            _db.Okul.Update(obj);
        }
    }
}
