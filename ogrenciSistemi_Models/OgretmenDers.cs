using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogrenciSistemi_Models
{
    public class OgretmenDers
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string OgretmenId{ get; set; }
        [ForeignKey("OgretmenId")]
        public virtual AppUser AppUser { get; set; }

        [Required]
        public int DersId { get; set; }
        [ForeignKey("DersId")]
        public virtual Dersler Dersler { get; set; }
    }
}
