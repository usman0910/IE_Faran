using System;
using System.IO;
using System.Web;
using System.Web.Mvc;
using ThemeEmbeding.Models;

namespace ThemeEmbeding.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Dashbord()
        {
            return View();
        }
        public ActionResult Products()
        {
            return View();
        }
        [HttpPost]
        public JsonResult ImageUpload(HttpPostedFileWrapper ImageFile)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            Guid SaveImageNameAs;
            SaveImageNameAs = Guid.NewGuid();
            var file = ImageFile;

            if (file != null)
            {

                var fileName = Path.GetFileName(file.FileName);
                var extention = Path.GetExtension(file.FileName);
                var filenamewithoutextension = Path.GetFileNameWithoutExtension(file.FileName);

                file.SaveAs(Server.MapPath("/UploadedImage/" + SaveImageNameAs + extention));

            }

            Helper.ProductExtension.ImageName = SaveImageNameAs.ToString();

            return Json(SaveImageNameAs.ToString(), JsonRequestBehavior.AllowGet);

        }

        public ActionResult Categories()
        {
            return View();
        }

        public ActionResult Stocks()
        {
            return View();
        }

        public ActionResult Orders()
        {
            return View();
        }

        public ActionResult Deliveries()
        {
            return View();
        }

    }
}