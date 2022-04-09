using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogrenciSistemi_Models
{
    public class AppUser : IdentityUser
    {
        public string adSoyad { get; set; }
    }
}
