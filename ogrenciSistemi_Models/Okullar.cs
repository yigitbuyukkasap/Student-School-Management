using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ogrenciSistemi_Models
{
    public class Okullar
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string OkulAd { get; set; }
        public int ManagerId { get; set; }
        [ForeignKey("ManagerId")]
        public virtual Manager Manager{ get; set; }
    }
}
