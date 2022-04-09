
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
    public class SinifOgrenciRepository : Repository<SinifOgrenci>, ISinifOgrenciRepository
    {

        private readonly ApplicationDbContext _db;
        private readonly IOgrenciRepository _ogrenciRepo;
        private readonly ISiniflarRepository _siniflarRepo;

        public SinifOgrenciRepository(
            ApplicationDbContext db,
            IOgrenciRepository ogrenciRepo,
            ISiniflarRepository siniflarRepo) : base(db)
        {
            _ogrenciRepo = ogrenciRepo;
            _siniflarRepo = siniflarRepo;
            _db = db;
        }

        public IEnumerable<SinifOgrencileriVM> GetSinifOgrencileri(int sinifId, bool varmi)
        {
            IEnumerable<SinifOgrenci> sinifOgrenciList = new List<SinifOgrenci>();
            List<SinifOgrencileriVM> sinifOgrencileriVMList = new List<SinifOgrencileriVM>();

            sinifOgrenciList = _db.SinifOgrenci.Where(x => x.SinifId == sinifId);
            if (varmi)
            {
                foreach (var item in sinifOgrenciList)
                {
                    sinifOgrencileriVMList.Add(new SinifOgrencileriVM()
                    {
                        ogrenci = _ogrenciRepo.FirstOrDefault(x => x.Id == item.OgrenciId),
                        SinifId = sinifId
                    });
                }
            }
            else
            {
                var okulId = _siniflarRepo.FirstOrDefault(x => x.Id == sinifId).OkulId;
                var ogrenciListesi = _ogrenciRepo.GetAll(x => x.OkulId == okulId);

                foreach (var item in ogrenciListesi)
                {
                    var yyy = sinifOgrenciList.Where(x => x.OgrenciId == item.Id).FirstOrDefault();
                    if (sinifOgrenciList.Where(x => x.OgrenciId == item.Id).FirstOrDefault() != null)
                    {
                        continue;
                    }
                    sinifOgrencileriVMList.Add(new SinifOgrencileriVM()
                    {
                        ogrenci = _ogrenciRepo.FirstOrDefault(x => x.Id == item.Id),
                        SinifId = sinifId
                    });
                }
            }

            return sinifOgrencileriVMList;
        }

        public void Update(SinifOgrenci obj)
        {
            _db.SinifOgrenci.Update(obj);
        }
    }
}
