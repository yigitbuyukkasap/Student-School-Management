
using ogrenciSistemi_Models;
using ogrenciSistemi_Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ogrenciSistemi_Data.Data.Repository.IRepository
{
    public interface ISinifYoklamaListesiRepository : IRepository<SinifYoklamaListesi>
    {
        void Update(SinifYoklamaListesi obj);
        void Detached(SinifYoklamaListesi obj);

        IEnumerable<SinifYoklamaListesi> getSinifYoklamaVeListesi(int yoklamaId);
    }
}
