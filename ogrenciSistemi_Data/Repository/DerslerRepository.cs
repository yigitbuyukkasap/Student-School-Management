using Microsoft.AspNetCore.Mvc.Rendering;
using ogrenciSistemi_Data.Data;
using ogrenciSistemi_Data.Data.Repository;
using ogrenciSistemi_Data.Repository.IRepository;
using ogrenciSistemi_Models;
using ogrenciSistemi_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogrenciSistemi_Data.Repository
{
    public class DerslerRepository : Repository<Dersler>, IDerslerRepository
    {
        private readonly ApplicationDbContext _db;
        public DerslerRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetAllDropdownList(bool isAdmin, int okulId)
        {
            if (isAdmin)
            {
                return _db.Dersler.Select(i => new SelectListItem()
                {
                    Text = i.DersAd,
                    Value = i.Id.ToString()
                });
            }
            else
            {
                return _db.Dersler.Where(x => x.OkulId == okulId).Select(i => new SelectListItem
                {
                    Text = i.DersAd,
                    Value = i.Id.ToString()
                });
            }
        }

        public void Update(Dersler obj)
        {
            _db.Dersler.Update(obj);
        }
    }
}
