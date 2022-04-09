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
    public interface IDerslerRepository : IRepository<Dersler>
    {
        void Update(Dersler obj);
        IEnumerable<SelectListItem> GetAllDropdownList(bool isAdmin, int okulId);
    }
}
