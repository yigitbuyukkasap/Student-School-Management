using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogrenciSistemi_Models
{
    public class Siniflar
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int OkulId { get; set; }
        [ForeignKey("OkulId")]
        public virtual Okul Okul { get; set; }
        [Required]
        public string sinifAd { get; set; }
    }
}
