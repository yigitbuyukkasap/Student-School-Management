using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogrenciSistemi_Models.ViewModels
{
    public class OgretmenDersEkleVM
    {
        public OgretmenDers OgretmenDers { get; set; }
        public int OkulId { get; set; }
        public IEnumerable<SelectListItem> DersListesi { get; set; }
        public IEnumerable<SelectListItem> OkullarListesi{ get; set; }
        public IEnumerable<SelectListItem> OgretmenListesi { get; set; }
        public IEnumerable<SelectListItem> SinifListesi{ get; set; }
    }
}
