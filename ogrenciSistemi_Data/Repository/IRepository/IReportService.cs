using ogrenciSistemi_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogrenciSistemi_Data
{
    public interface IReportService
    {
        public byte[] GeneratePdfReport(IEnumerable<SinifYoklamaListesi> data);
        IEnumerable<SinifYoklamaListesi> getData(int Id);
    }
}
