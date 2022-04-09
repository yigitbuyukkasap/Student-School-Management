using Microsoft.AspNetCore.Mvc.Rendering;
using ogrenciSistemi_Data.Data.Repository.IRepository;
using ogrenciSistemi_Models;
using ogrenciSistemi_Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogrenciSistemi_Data.Repository.IRepository
{
    public interface IDersProgramiRepository : IRepository<DersProgrami>
    {
        void Update(DersProgrami obj);

        IEnumerable<DersProgramiVM> GetSinifDersProgrami(int Id);
    }
}
