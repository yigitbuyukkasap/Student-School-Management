using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogrenciSistemi_Models.ViewModels
{
    public class SinifYoklamaVM
    {
        [Required]
        public int SinifId { get; set; }
        [Required]
        public string Durum{ get; set; }
        [Required]
        public string OgrenciId { get; set; }
        [Required]
        public string DersId { get; set; }
        [Required]
        public int Gun{ get; set; }
        [Required]
        public int Saat { get; set; }
        [Required]
        public string OgretmenAd { get; set; }
    }
}
