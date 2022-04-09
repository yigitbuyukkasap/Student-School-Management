using Microsoft.AspNetCore.Mvc.Rendering;
using ogrenciSistemi_Data.Data;
using ogrenciSistemi_Data.Data.Repository;
using ogrenciSistemi_Data.Repository.IRepository;
using ogrenciSistemi_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogrenciSistemi_Data.Repository
{
    public class SiniflarRepository : Repository<Siniflar>, ISiniflarRepository
    {
        private readonly ApplicationDbContext _db;
        public SiniflarRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public IEnumerable<SelectListItem> GetAllDropdownList(bool isAdmin,int okulId)
        {
            if (isAdmin)
            {
                return _db.Siniflar.Select(i => new SelectListItem()
                {
                    Text = i.sinifAd,
                    Value = i.Id.ToString()
                });
            }
            else
            {
                return _db.Siniflar.Where(x => x.OkulId == okulId).Select(i => new SelectListItem
                {
                    Text = i.sinifAd,
                    Value = i.Id.ToString()
                });
            }
        }

        public void Update(Siniflar obj)
        {
            _db.Siniflar.Update(obj);
        }
    }
}
