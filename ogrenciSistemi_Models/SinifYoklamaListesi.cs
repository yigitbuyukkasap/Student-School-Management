using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogrenciSistemi_Models
{
    public class SinifYoklamaListesi
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int SinifYoklamaId { get; set; }
        [ForeignKey("SinifYoklamaId")]
        public SinifYoklama SinifYoklama { get; set; }
        [Required]
        public int OgrenciId { get; set; }
        [ForeignKey("OgrenciId")]
        public Ogrenci Ogrenci{ get; set; }
        [Required]
        public string Durum { get; set; }
    }
}
