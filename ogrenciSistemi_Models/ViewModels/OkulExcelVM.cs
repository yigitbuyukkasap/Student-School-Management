using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogrenciSistemi_Models.ViewModels
{
    public class OkulExcelVM
    {
        [Required]
        public string OkulAd { get; set; }
        public string ManagerAd { get; set; }
        public IList<Ogrenci> Ogrenci{ get; set; }
    }
}
