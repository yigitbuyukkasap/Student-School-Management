using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogrenciSistemi_Models
{
    public class SinifOgrenci
    {
        public int Id { get; set; }

        [Required]
        public int SinifId { get; set; }
        [ForeignKey("SinifId")]
        public virtual Siniflar Sinif { get; set; }

        [Required]
        public int OgrenciId { get; set; }
        [ForeignKey("OgrenciId")]
        public virtual Ogrenci Ogrenci{ get; set; }

    }
}
