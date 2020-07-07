using HotBag.AspNetCore.Modules;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using DinkToPdf;
using DinkToPdf.Contracts;
using System.IO;
using HotBag.Plugin.PdfGenerator.Utility;
using HotBag.Plugin.PdfGenerator.PdfService;
using System.Reflection;

namespace HotBag.Plugin.PdfGenerator
{  
    public class PdfGeneratorModule : ApplicationModule
    {
        public override string ModuleName => "Plugin.PdfGenerator";

        public override void Initialize(IServiceCollection serviceCollection, IConfiguration configuration)
        {

            var context = new CustomAssemblyLoadContext();

            var buildDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            context.LoadUnmanagedLibrary(Path.Combine(buildDir, "libwkhtmltox.dll"));

            serviceCollection.AddSingleton(typeof(IConverter), new SynchronizedConverter(new PdfTools()));


            serviceCollection.AddTransient<IPdfConverterService, PdfConverterService>();
        
        }
    }
}
