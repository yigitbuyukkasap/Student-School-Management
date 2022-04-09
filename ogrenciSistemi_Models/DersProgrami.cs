using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogrenciSistemi_Models
{
    public class DersProgrami
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int SinifId { get; set; }
        [ForeignKey("SinifId")]
        public virtual Siniflar Siniflar { get; set; }

        [Required]
        public int DersId { get; set; }
        [ForeignKey("DersId")]
        public virtual Dersler Dersler{ get; set; }

        [Required]
        public string gun { get; set; }
        [Required]
        public string saat { get; set; }

    }
}
