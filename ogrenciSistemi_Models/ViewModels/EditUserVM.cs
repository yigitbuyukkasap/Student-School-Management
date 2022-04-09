using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogrenciSistemi_Models.ViewModels
{
    public class EditUserVM
    {
        public AppUser User { get; set; }

        public string UserRole { get; set; }
        public string NewRole { get; set; }

        public IEnumerable<SelectListItem> RoleSelectList { get; set; }
    }
}
