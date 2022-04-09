using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogrenciSistemi_Models.ViewModels
{
    public class DersUpsertVM
    {
        public Dersler Ders { get; set; }
        public IEnumerable<SelectListItem> Okullar { get; set; }
    }
}
