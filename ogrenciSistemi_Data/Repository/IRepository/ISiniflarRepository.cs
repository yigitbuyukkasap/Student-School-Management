using Microsoft.AspNetCore.Mvc.Rendering;
using ogrenciSistemi_Data.Data.Repository.IRepository;
using ogrenciSistemi_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogrenciSistemi_Data.Repository.IRepository
{
    public interface ISiniflarRepository : IRepository<Siniflar>
    {
        void Update(Siniflar obj);

        IEnumerable<SelectListItem> GetAllDropdownList(bool isAdmin, int okulId);
    }
}
