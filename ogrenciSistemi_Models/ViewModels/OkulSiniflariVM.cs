using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogrenciSistemi_Models.ViewModels
{
    public class OkulSiniflariVM
    {
        public int OkulId { get; set; }
        public IEnumerable<Siniflar> Siniflar { get; set; }

        public IEnumerable<SelectListItem> OkullarSelectList { get; set; }
    }
}
