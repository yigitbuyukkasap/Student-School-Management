using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogrenciSistemi_Models.ViewModels
{
    public class DerslerListelemeVM
    {
        public string UserRole { get; set; }
        public string UserId { get; set; }
        public int OkulId { get; set; }
        public int SinifId { get; set; }

        public IEnumerable<SelectListItem> Okullar{ get; set; }
        public IEnumerable<Dersler> Dersler { get; set; }
    }
}
