
using ogrenciSistemi_Data.Data;
using ogrenciSistemi_Data.Data.Repository;
using ogrenciSistemi_Data.Data.Repository.IRepository;
using ogrenciSistemi_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ogrenciSistemi_Data.Data.Repository
{
    public class SinifYoklamaRepository : Repository<SinifYoklama>, ISinifYoklamaRepository
    {

        private readonly ApplicationDbContext _db;

        public SinifYoklamaRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(SinifYoklama obj)
        {
            _db.SinifYoklama.Update(obj);
        }
    }
}
