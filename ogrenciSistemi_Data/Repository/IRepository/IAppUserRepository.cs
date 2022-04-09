
using Microsoft.AspNetCore.Mvc.Rendering;
using ogrenciSistemi_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ogrenciSistemi_Data.Data.Repository.IRepository
{
    public interface IAppUserRepository : IRepository<AppUser>
    {
        void Update(AppUser obj);
        IEnumerable<SelectListItem> GetTeacherList();

    }
}
