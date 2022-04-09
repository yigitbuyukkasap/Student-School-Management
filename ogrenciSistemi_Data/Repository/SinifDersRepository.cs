
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
    public class SinifDersRepository : Repository<SinifDers>, ISinifDersRepository
    {

        private readonly ApplicationDbContext _db;
        public IAppUserRepository _appUserRepo;
        public IOgretmenDersRepository _ogretmenDersRepo;

        public SinifDersRepository(ApplicationDbContext db, IAppUserRepository appUserRepo, IOgretmenDersRepository ogretmenDersRepo) : base(db)
        {
            _db = db;
            _ogretmenDersRepo = ogretmenDersRepo;
            _appUserRepo = appUserRepo;
        }

        public IEnumerable<SinifDersListesiVM> GetSinifDersListesi(int? Id)
        {
            var sinifDersleri = _db.SinifDers.Where(x => x.SinifIarId == Id);

            List<SinifDersListesiVM> sinifDersListesiVM = new List<SinifDersListesiVM>();
            foreach (var obj in sinifDersleri)
            {

                sinifDersListesiVM.Add(new SinifDersListesiVM()
                {
                    DersId = obj.DersId,
                    DersAd = _db.Dersler.FirstOrDefault(x => x.Id == obj.DersId).DersAd,
                    OgretmenAd = _ogretmenDersRepo
                                    .GetAllOkuldersOgretmenId(obj.DersId)
                                    .FirstOrDefault(x => x.Value == obj.OgretmenId).Text
                });
            }
            return sinifDersListesiVM;
        }

        public void Update(SinifDers obj)
        {
            _db.SinifDers.Update(obj);
        }
    }
}
