IronPdf.License.LicenseKey = "";
IronPdf.Logging.Logger.LoggingMode = IronPdf.Logging.Logger.LoggingModes.File;
IronPdf.Logging.Logger.LogFilePath = "./IronPdfLog.txt";

var bodyHtml = """<a href="https://google.com" id="test" target="_blank">This link works</a>""";
var footerHtml = """<a href="https://google.com" id="test" target="_blank">This link doesn't</a>""";

var pdf = ChromePdfRenderer.StaticRenderHtmlAsPdf(
    bodyHtml, 
    new ChromePdfRenderOptions
    {
        HtmlFooter = new HtmlHeaderFooter
        {
            HtmlFragment = footerHtml
        },
    });

File.WriteAllBytes("./Output.pdf", pdf.BinaryData);