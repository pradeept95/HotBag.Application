using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HotBag.Web.Models;
using HotBag.Plugin.PdfGenerator.PdfService;
using DinkToPdf;
using System.IO;
using HotBag.Plugin.Maintenance;

namespace HotBag.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public readonly IPdfConverterService _pdfConverterService;

        public HomeController(ILogger<HomeController> logger, IPdfConverterService pdfConverterService)
        {
            _logger = logger;
            _pdfConverterService = pdfConverterService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [Route("/dm")]
        [HttpGet]
        public IActionResult DisableMaintenance()
        {
            MaintenanceConfig.DisableMaintenanceMode();
            return Content("Success");
        } 
        
        [Route("/em")]
        [HttpGet]
        public IActionResult EnableMaintenance()
        {
            MaintenanceConfig.EnableMaintenanceMode();
            return Content("Success");
        }


        [HttpGet]
        public IActionResult ShowPdf()
        {
            var globalSettings = new GlobalSettings
            {
                ColorMode = ColorMode.Color,
                Orientation = Orientation.Portrait,
                PaperSize = PaperKind.A4,
                Margins = new MarginSettings { Top = 10 },
                DocumentTitle = "PDF Report",
                //Out = @"D:\PDFCreator\Employee_Report.pdf"  USE THIS PROPERTY TO SAVE PDF TO A PROVIDED LOCATION
            };

            var objectSettings = new ObjectSettings
            {
                PagesCount = true,
                // HtmlContent = TemplateGenerator.GetHTMLString(),
                Page = "https://www.ideashubs.com/everest-base-camp-trek-best-time-to-trek-in-everest-base-camp/", //USE THIS PROPERTY TO GENERATE PDF CONTENT FROM AN HTML PAGE
                WebSettings = { DefaultEncoding = "utf-8", UserStyleSheet = Path.Combine(Directory.GetCurrentDirectory(), "assets", "styles.css") },
                HeaderSettings = { FontName = "Arial", FontSize = 9, Right = "Page [page] of [toPage]", Line = true },
                FooterSettings = { FontName = "Arial", FontSize = 9, Line = true, Center = "Report Footer" }
            };

            var file = _pdfConverterService.ConvertToPdfFile(globalSettings, objectSettings); 
            return File(file, "application/pdf", $"pdf_generated_{DateTime.Now.Ticks}.pdf");

        }
    }
}
