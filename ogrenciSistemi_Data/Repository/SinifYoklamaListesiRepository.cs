
using Microsoft.EntityFrameworkCore;
using ogrenciSistemi_Data.Data;
using ogrenciSistemi_Data.Data.Repository;
using ogrenciSistemi_Data.Data.Repository.IRepository;
using ogrenciSistemi_Models;
using ogrenciSistemi_Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ogrenciSistemi_Data.Data.Repository
{
    public class SinifYoklamaListesiRepository : Repository<SinifYoklamaListesi>, ISinifYoklamaListesiRepository
    {

        private readonly ApplicationDbContext _db;
        private readonly ISinifYoklamaRepository _sinifYoklamaRepo;

        public SinifYoklamaListesiRepository(ApplicationDbContext db, ISinifYoklamaRepository sinifYoklamaRepo) : base(db)
        {
            _db = db;
            _sinifYoklamaRepo = sinifYoklamaRepo;
        }
        public void Update(SinifYoklamaListesi obj)
        {
            var x = _db.SinifYoklamaListesi.Update(obj);
        }

        public void Detached(SinifYoklamaListesi obj)
        {
            _db.Entry(obj).State = EntityState.Detached;
        }

        public IEnumerable<SinifYoklamaListesi> getSinifYoklamaVeListesi(int yoklamaId)
        {
            SinifYoklamaListesi sYPdfVM = new SinifYoklamaListesi();
            var yyyy = _sinifYoklamaRepo.GetAll(includeProperties: "SinifYoklamaListesi,Ogrenci,Dersler,AppUser");
            throw new NotImplementedException();
        }
    }
}
