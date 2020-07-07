using DinkToPdf;
using System.Collections.Generic;

namespace HotBag.Plugin.PdfGenerator.PdfService
{
    public interface IPdfConverterService
    {
        byte[] ConvertToPdfFile(GlobalSettings globalSettings, ObjectSettings objectSettings);
        byte[] ConvertToPdfFile(GlobalSettings globalSettings, ObjectSettings objectSettings, bool saveToDirectory);

    }
}