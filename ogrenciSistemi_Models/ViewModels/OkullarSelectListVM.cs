using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogrenciSistemi_Models.ViewModels
{
    public class OkullarSelectListVM
    {
        [Required]
        public int OkulId { get; set; }
        [Required]
        public string sinifAd { get; set; }
        public IEnumerable<SelectListItem> OkullarSelectList { get; set; }
    }
}
