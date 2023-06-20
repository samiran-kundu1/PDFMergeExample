using Microsoft.AspNetCore.Mvc;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System.Reflection.PortableExecutable;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PDFMergeController : ControllerBase
    {
        // GET: api/<PDFMergeController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            // Create a new PDF document
            PdfDocument document = new PdfDocument();
            document = PdfReader.Open(@"C:\Users\SAMIRAN\Downloads\testfileformerge.pdf", PdfDocumentOpenMode.Import);
            document.Info.Title = "Created with PDFsharp";
            //document.InsertPage(0);

            // Create an empty page
            PdfDocument document1 = new PdfDocument();
            document1 = PdfReader.Open(@"C:\Users\SAMIRAN\OneDrive\Desktop\Fillable_PDF_Sample_from_TheWebJockeys_vC5.pdf", PdfDocumentOpenMode.Import);
            document.AddPage(document1.Pages[0]);

            //// Get an XGraphics object for drawing
            //XGraphics gfx = XGraphics.FromPdfPage(page);

            //// Create a font
            //XFont font = new XFont("Verdana", 20, XFontStyle.BoldItalic);

            //// Draw the text
            //gfx.DrawString("Hello, World!", font, XBrushes.Black,
            //  new XRect(0, 0, page.Width, page.Height),
            //  XStringFormats.Center);

            // Save the document...
            const string filename = @"C:\Users\SAMIRAN\OneDrive\Desktop\MergedFile.pdf";
            document.Save(filename);
            // ...and start a viewer.
            //Process.Start(filename);
            return new string[] { "value1", "value2" };
        }

        // GET api/<PDFMergeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PDFMergeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            // Create a new PDF document
            PdfDocument document = new PdfDocument();
            document = PdfReader.Open(@"C:\Users\SAMIRAN\Downloads\testfileformerge.pdf", PdfDocumentOpenMode.Import);
            document.Info.Title = "Created with PDFsharp";
            //document.InsertPage(0);

            // Create an empty page
            PdfDocument document1 = new PdfDocument();
            document1 = PdfReader.Open(@"C:\Users\SAMIRAN\OneDrive\Desktop\Fillable_PDF_Sample_from_TheWebJockeys_vC5.pdf", PdfDocumentOpenMode.Import);
            document.AddPage(document1.Pages[0]);

            //// Get an XGraphics object for drawing
            //XGraphics gfx = XGraphics.FromPdfPage(page);

            //// Create a font
            //XFont font = new XFont("Verdana", 20, XFontStyle.BoldItalic);

            //// Draw the text
            //gfx.DrawString("Hello, World!", font, XBrushes.Black,
            //  new XRect(0, 0, page.Width, page.Height),
            //  XStringFormats.Center);

            // Save the document...
            const string filename = @"C:\Users\SAMIRAN\OneDrive\Desktop\MergedFile.pdf";
            document.Save(filename);
            // ...and start a viewer.
            //Process.Start(filename);
        }

        // PUT api/<PDFMergeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PDFMergeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
