using System;
using System.IO;
using System.Web;
using System.Web.Mvc;

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
        public string ImageUpload(HttpPostedFileWrapper ImageFile)
        {

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


            return "";

        }

        public ActionResult Categories()
        {
            return View();
        }

        public ActionResult Brands()
        {
            return View();
        }

        public ActionResult Stocks()
        {
            return View();
        }

        public ActionResult NewOrders()
        {
            return View();
        }

        public ActionResult InProgressOrders()
        {
            return View();
        }
        public ActionResult CompletedOrders()
        {
            return View();
        }
        public ActionResult OrderDetails()
        {
            return View();
        }
    }
}