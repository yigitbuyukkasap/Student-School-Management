using DinkToPdf;
using DinkToPdf.Contracts;
using Microsoft.AspNetCore.Mvc;
using ogrenciSistemi_Data.Data.Repository.IRepository;
using ogrenciSistemi_Models;
using ogrenciSistemi_Models.ViewModels;
using ogrenciSistemi_Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogrenciSistemi_Data
{
    public class ReportService : IReportService
    {
        private readonly IConverter _converter;
        private readonly ISinifYoklamaListesiRepository _sinifYoklamaListesiRepo;
        public ReportService(IConverter converter, ISinifYoklamaListesiRepository sinifYoklamaListesiRepo)
        {
            _converter = converter;
            _sinifYoklamaListesiRepo = sinifYoklamaListesiRepo;
        }
        public byte[] GeneratePdfReport(IEnumerable<SinifYoklamaListesi> data)
        {
            var globalSettings = new GlobalSettings
            {
                ColorMode = ColorMode.Color,
                Orientation = Orientation.Portrait,
                PaperSize = PaperKind.A4,
                Margins = new MarginSettings { Top = 10 },
                DocumentTitle = "Yoklama Raporu"
            };
            var objectSettings = new ObjectSettings
            {
                PagesCount = true,
                HtmlContent = GetHTMLString(data),
                WebSettings = { DefaultEncoding = "utf-8", UserStyleSheet = Path.Combine(Directory.GetCurrentDirectory(), "assets", "styles.css") },
                HeaderSettings = { FontName = "Arial", FontSize = 9, Right = "Page [page] of [toPage]", Line = true },
                FooterSettings = { FontName = "Arial", FontSize = 9, Line = true, Center = "Yoklama Raporu" }
            };
            var pdf = new HtmlToPdfDocument()
            {
                GlobalSettings = globalSettings,
                Objects = { objectSettings }
            };

            var file = _converter.Convert(pdf);
            return file;
        }

        public IEnumerable<SinifYoklamaListesi> getData(int Id)
        {
            var data = _sinifYoklamaListesiRepo.GetAll(x => x.SinifYoklamaId == Id, includeProperties: "SinifYoklama,Ogrenci");
            return data;
        }
        public static string GetHTMLString(IEnumerable<SinifYoklamaListesi> data)
        {
            var sb = new StringBuilder();

            sb.Append
            (@"
                        <html>
                            <head>
                            </head>
                            <body>
                                <table class='table table-striped custab col-md-12'>
                                    <thead>
                                        <tr>
                                            <th>Öğrenci Adı</th>
                                            <th> Durumu </th>
                                        </tr>
                                    </thead>");
            foreach (var obj in data)
            {
                sb.AppendFormat(@"<tr>
                                            <td>{0}</td>
                                            <td>{1}</td>
                                        </tr>",obj.Ogrenci.ad + " " + obj.Ogrenci.soyad, obj.Durum);
            }
            sb.AppendFormat(@"
                                </table>
                            </body>
                        </html>

            ");
            return sb.ToString();
        }

    }
}
