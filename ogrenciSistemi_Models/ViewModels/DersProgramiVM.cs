using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogrenciSistemi_Models.ViewModels
{
    public class DersProgramiVM
    {
        public int SinifId { get; set; }
        public int DersId { get; set; }
        public string DersAd { get; set; }
        public string OgretmenAd { get; set; }
        public string gun { get; set; }
        public string saat { get; set; }
    }
}
