
using ogrenciSistemi_Models;
using ogrenciSistemi_Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ogrenciSistemi_Data.Data.Repository.IRepository
{
    public interface ISinifOgrenciRepository : IRepository<SinifOgrenci>
    {
        void Update(SinifOgrenci obj);

        IEnumerable<SinifOgrencileriVM> GetSinifOgrencileri(int sinifId,bool varmi);
    }
}
