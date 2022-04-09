using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ogrenciSistemi_Models
{
    public class Okul
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Okul Ad")]
        public string OkulAd { get; set; }
        [DisplayName("Müdür Id")]
        public string ManagerId { get; set; }
        [ForeignKey("ManagerId")]
        public virtual AppUser AppUser{ get; set; }
    }
}
