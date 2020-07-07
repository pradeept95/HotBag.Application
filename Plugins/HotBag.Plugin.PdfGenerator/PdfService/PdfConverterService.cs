using DinkToPdf;
using DinkToPdf.Contracts;
using HotBag.AspNetCore.DI;
using HotBag.Plugin.PdfGenerator.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HotBag.Plugin.PdfGenerator.PdfService
{
    public class PdfConverterService : IPdfConverterService
    {
        private IConverter _converter;

        public PdfConverterService(IConverter converter)
        {
            _converter = converter;
        }

        public byte[] ConvertToPdfFile(GlobalSettings globalSettings, ObjectSettings objectSettings)
        {
            try
            {
                var pdf = new HtmlToPdfDocument()
                {
                    GlobalSettings = globalSettings,
                    Objects = { objectSettings }
                };

                var file = _converter.Convert(pdf);

                return file;
            }
            catch (Exception e)
            {

                throw e;
            }

        }

        public byte[] ConvertToPdfFile(GlobalSettings globalSettings, ObjectSettings objectSettings, bool saveToDirectory)
        {
            try
            {
                if (saveToDirectory && string.IsNullOrEmpty(globalSettings.Out))
                {
                    throw new Exception("Out property should initialize to save");
                }

                var pdf = new HtmlToPdfDocument()
                {
                    GlobalSettings = globalSettings,
                    Objects = { objectSettings }
                };

                var file = _converter.Convert(pdf);
                //
                //IF WE USE Out PROPERTY IN THE GlobalSettings CLASS, THIS IS ENOUGH FOR CONVERSION

                return file;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
