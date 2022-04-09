
using Microsoft.AspNetCore.Mvc.Rendering;
using ogrenciSistemi_Data.Data;
using ogrenciSistemi_Data.Data.Repository;
using ogrenciSistemi_Data.Data.Repository.IRepository;
using ogrenciSistemi_Data.Repository.IRepository;
using ogrenciSistemi_Models;
using ogrenciSistemi_Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ogrenciSistemi_Data.Data.Repository
{
    public class OgretmenDersRepository : Repository<OgretmenDers>, IOgretmenDersRepository
    {

        private readonly ApplicationDbContext _db;
        private readonly IAppUserRepository _appUserRepo;


        public OgretmenDersRepository(ApplicationDbContext db, IAppUserRepository appUserRepo) : base(db)
        {
            _db = db;
            _appUserRepo = appUserRepo;
        }

        public IEnumerable<SelectListItem> GetAllOkuldersOgretmenId(int dersId)
        {
            var ogretmenler = _db.OgretmenDers.Where(x => x.DersId == dersId).Select(y => y.OgretmenId);
            List<SelectListItem> ogretmenList = new List<SelectListItem>();
            foreach (var obj in ogretmenler)
            {
                ogretmenList.Add(new SelectListItem()
                {
                    Text = _appUserRepo.FirstOrDefault(x => x.Id == obj).adSoyad,
                    Value = obj
                });
            }
            return ogretmenList;
        }

        public void Update(OgretmenDers obj)
        {
            _db.OgretmenDers.Update(obj);
        }
    }
}
