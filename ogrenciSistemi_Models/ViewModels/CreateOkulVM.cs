using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogrenciSistemi_Models.ViewModels
{
    public class CreateOkulVM
    {
        public Okul Okul { get; set; }
        public IEnumerable<SelectListItem> Managers { get; set; }

    }
}
