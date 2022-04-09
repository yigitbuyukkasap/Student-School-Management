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
    public interface ISinifDersRepository : IRepository<SinifDers>
    {
        void Update(SinifDers obj);

        IEnumerable<SinifDersListesiVM> GetSinifDersListesi(int? Id);
    }
}
