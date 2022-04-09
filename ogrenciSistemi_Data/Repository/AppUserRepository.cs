
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using ogrenciSistemi_Data.Data;
using ogrenciSistemi_Data.Data.Repository;
using ogrenciSistemi_Data.Data.Repository.IRepository;
using ogrenciSistemi_Models;
using ogrenciSistemi_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ogrenciSistemi_Data.Data.Repository
{
    public class AppUserRepository : Repository<AppUser>, IAppUserRepository
    {

        private readonly ApplicationDbContext _db;
        private readonly UserManager<IdentityUser> _userManager;
        public AppUserRepository(ApplicationDbContext db, UserManager<IdentityUser> userManager) : base(db)
        {
            _db = db;
            _userManager = userManager;
        }
        public void Update(AppUser obj)
        {
            _db.AppUser.Update(obj);
        }

        public IEnumerable<SelectListItem> GetTeacherList()
        {
            var teacherList = _userManager.GetUsersInRoleAsync(WebConst.TeacherRole).GetAwaiter().GetResult();
            List<string> manager = new List<string>();
            return teacherList.Select(i => new SelectListItem()
            {
                Text = _db.AppUser.FirstOrDefault(x => x.Email == i.Email).adSoyad,
                Value = i.Id
            });
        }
    }
}
