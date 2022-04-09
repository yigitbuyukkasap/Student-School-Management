using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ogrenciSistemi_Data.Data;
using ogrenciSistemi_Models;
using ogrenciSistemi_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogrenciSistemi_Data.Initializer
{
    public class DbInitializer
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public DbInitializer(ApplicationDbContext db, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public void Initialize()
        {
            try
            {
                if (_db.Database.GetPendingMigrations().Count() > 0)
                {
                    _db.Database.Migrate();
                }
            }
            catch (Exception ex)
            {


            }
            if (!_roleManager.RoleExistsAsync(WebConst.AdminRole).GetAwaiter().GetResult())
            {
                _roleManager.CreateAsync(new IdentityRole(WebConst.AdminRole)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(WebConst.TeacherRole)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(WebConst.ManagerRole)).GetAwaiter().GetResult();
            }
            else
            {
                return;
            }
            _userManager.CreateAsync(new AppUser
            {
                UserName = "admin@gmail.com",
                Email = "admin@gmail.com",
                EmailConfirmed = true,
                adSoyad = "Admin tester",
                PhoneNumber = "111111111111",
            }, "Temp1234*").GetAwaiter().GetResult();
            AppUser user = _db.AppUser.FirstOrDefault(y => y.Email == "admin@gmail.com");
            _userManager.AddToRoleAsync(user, WebConst.AdminRole).GetAwaiter().GetResult();
        }
    }
}
