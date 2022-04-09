using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using ogrenciSistemi_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ogrenciSistemi_Data.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Ogrenci> Ogrenci { get; set; }
        public DbSet<AppUser> AppUser { get; set; }

        public DbSet<Manager> Manager { get; set; }

        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<SinifDers> SinifDers { get; set; }

        //public DbSet<Okullar> Okullar { get; set; }
        public DbSet<Siniflar> Siniflar { get; set; }
        public DbSet<OgretmenDers> OgretmenDers { get; set; }
        public DbSet<Dersler> Dersler { get; set; }
        public DbSet<Okul> Okul { get; set; }
        public DbSet<DersProgrami> DersProgrami { get; set; }
        public DbSet<SinifOgrenci> SinifOgrenci{ get; set; }
        public DbSet<SinifYoklama> SinifYoklama{ get; set; }
        public DbSet<SinifYoklamaListesi> SinifYoklamaListesi{ get; set; }
    }
}
