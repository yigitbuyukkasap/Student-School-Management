using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogrenciSistemi_Models.ViewModels
{
    public class OgrenciVM
    {
        public Ogrenci Ogrenci { get; set; }
        public int OkulId { get; set; }
        public IEnumerable<SelectListItem> OkullarListesi{ get; set; }
        public IEnumerable<Ogrenci> OgrenciListesi{ get; set; }
    }
}
