using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting.Internal;
using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Port.Controllers
{
    public class ArchivesController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ArchivesController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public FileResult MyCvDownload() 
        {
            string path = _webHostEnvironment.ContentRootPath + @"\wwwroot\archives\my_cv.pdf";
            byte[] cvBytes = System.IO.File.ReadAllBytes(path);

            string cvDownloadName = "cv_download.pdf";
            return File(cvBytes, System.Net.Mime.MediaTypeNames.Application.Pdf, cvDownloadName);
        }
    }
}
