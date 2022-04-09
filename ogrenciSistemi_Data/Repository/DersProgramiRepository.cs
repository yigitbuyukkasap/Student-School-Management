
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
    public class DersProgramiRepository : Repository<DersProgrami>, IDersProgramiRepository
    {

        private readonly ApplicationDbContext _db;
        public IAppUserRepository _appUserRepo;
        public IOgretmenDersRepository _ogretmenDersRepo;

        public DersProgramiRepository(ApplicationDbContext db, IAppUserRepository appUserRepo, IOgretmenDersRepository ogretmenDersRepo) : base(db)
        {
            _db = db;
            _ogretmenDersRepo = ogretmenDersRepo;
            _appUserRepo = appUserRepo; 
        }

        public IEnumerable<DersProgramiVM> GetSinifDersProgrami(int Id)
        {
            var dpListesi = _db.DersProgrami.Where(x => x.SinifId== Id);

            List<DersProgramiVM> dersProgramiVM = new List<DersProgramiVM>();
            foreach (var obj in dpListesi)
            {
                string ogretmenId = _db.SinifDers.FirstOrDefault(x=> x.SinifIarId == Id && x.DersId == obj.DersId).OgretmenId;
                dersProgramiVM.Add( new DersProgramiVM()
                {
                    SinifId = Id,
                    DersId = obj.DersId,
                    DersAd = _db.Dersler.FirstOrDefault(x => x.Id == obj.DersId).DersAd,
                    OgretmenAd = _ogretmenDersRepo
                                    .GetAllOkuldersOgretmenId(obj.DersId)
                                    .FirstOrDefault(x => x.Value == ogretmenId).Text,
                    gun = _db.DersProgrami.FirstOrDefault(x => x.Id == obj.Id).gun,
                    saat = _db.DersProgrami.FirstOrDefault(x => x.Id == obj.Id).saat,
                });
            }
            return dersProgramiVM;
        }

        public void Update(DersProgrami obj)
        {
            _db.DersProgrami.Update(obj);
        }
    }
}
