
using Microsoft.AspNetCore.Mvc.Rendering;
using ogrenciSistemi_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ogrenciSistemi_Data.Data.Repository.IRepository
{
    public interface IOkullarRepository : IRepository<Okul>
    {
        void Update(Okul obj);
        IEnumerable<SelectListItem> GetManagerList();
        IEnumerable<SelectListItem> GetAllDropdownListOkul(bool isAdmin, string userId);


    }
}
