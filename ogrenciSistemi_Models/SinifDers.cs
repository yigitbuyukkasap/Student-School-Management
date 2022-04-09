using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogrenciSistemi_Models
{
    public class SinifDers
    {
        [Key]
        public int Id { get; set; }
        public int? SinifIarId { get; set; }
        [ForeignKey("SinifIarId")]
        public virtual Siniflar Siniflar { get; set; }
        [Required]
        public int DersId { get; set; }
        [ForeignKey("DersId")]
        public virtual Dersler Dersler { get; set; }

        public string OgretmenId { get; set; }
        [ForeignKey("OgretmenId")]
        public virtual AppUser AppUser { get; set; }
    }
}
