IronPdf.License.LicenseKey = "";
IronPdf.Logging.Logger.LoggingMode = IronPdf.Logging.Logger.LoggingModes.File;
IronPdf.Logging.Logger.LogFilePath = "./IronPdfLog.txt";

var bodyHtml = """<a href="https://google.com" target="_blank">This link works</a>""";
var headerFooterHtml = """<a href="https://google.com" target="_blank">This link doesn't work</a>""";

var pdf = ChromePdfRenderer.StaticRenderHtmlAsPdf(
    bodyHtml, 
    new ChromePdfRenderOptions
    {
        HtmlHeader = new HtmlHeaderFooter
        {
            HtmlFragment = headerFooterHtml
        },
        HtmlFooter = new HtmlHeaderFooter
        {
            HtmlFragment = headerFooterHtml
        }
    });

File.WriteAllBytes("./Output.pdf", pdf.BinaryData);