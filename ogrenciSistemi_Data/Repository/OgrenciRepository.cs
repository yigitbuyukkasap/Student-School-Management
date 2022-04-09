
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
    public class OgrenciRepository : Repository<Ogrenci>, IOgrenciRepository
    {

        private readonly ApplicationDbContext _db;

        public OgrenciRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Ogrenci obj)
        {
            _db.Ogrenci.Update(obj);
        }
    }
}
