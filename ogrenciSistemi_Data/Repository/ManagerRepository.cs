
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ogrenciSistemi_Data.Data;
using ogrenciSistemi_Data.Data.Repository;
using ogrenciSistemi_Data.Data.Repository.IRepository;
using ogrenciSistemi_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ogrenciSistemi_Data.Data.Repository
{
    public class ManagerRepository : Repository<Manager>, IManagerRepository
    {

        private readonly ApplicationDbContext _db;
        private readonly UserManager<AppUser> _userManager;


        public ManagerRepository(ApplicationDbContext db, UserManager<AppUser> userManager) : base(db)
        {
            _db = db;
            _userManager = userManager;
        }
        public void Update(Manager obj)
        {
            _db.Manager.Update(obj);
        }

    }
}
