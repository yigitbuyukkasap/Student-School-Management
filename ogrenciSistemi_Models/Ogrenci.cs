using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ogrenciSistemi_Models
{
    public class Ogrenci
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ad { get; set; }
        public string soyad { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string tc { get; set; }
        public int OkulId { get; set; }
        [ForeignKey("OkulId")]
        public virtual Okul Okul { get; set; }
        public DateTime dogumTarihi { get; set; }
        public string evAdresi { get; set; }
        public string sehir { get; set; }
        public string telefonNo { get; set; }
        public string anneAd { get; set; }
        public string babaAd { get; set; }
    }
}
