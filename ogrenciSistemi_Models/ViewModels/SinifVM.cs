using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogrenciSistemi_Models.ViewModels
{
    public class SinifVM
    {
        public Siniflar Sinif { get; set; }
        public Dersler Ders { get; set; }

        public OgretmenDers OgretmenDers { get; set; }
        public int OkulId { get; set; }
        public int SinifId { get; set; }
        public IEnumerable<SelectListItem> OkulunDersleriListesi { get; set; }
        public IEnumerable<SelectListItem> OgretmenListesi { get; set; }

        public IEnumerable<SinifDersListesiVM> SinifDersListesiVM { get; set; }
        public IEnumerable<DersProgramiVM> DersProgramiVM{ get; set; }
        public IEnumerable<SinifOgrencileriVM> OgrenciListesiVarTrue{ get; set; }
        public IEnumerable<SinifOgrencileriVM> OgrenciListesiVarFalse { get; set; }
        public IEnumerable<SinifYoklama> SinifYoklama { get; set; }
    }
}
