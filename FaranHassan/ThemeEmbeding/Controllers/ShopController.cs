using System.Web.Mvc;

namespace ThemeEmbeding.Controllers
{
    public class ShopController : Controller
    {
        public ShopController()
        {

        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cart()
        {
            return View();
        }

        public ActionResult Checkout()
        {
            return View();
        }

        public ActionResult ProductDetail(int Id)
        {
            return View();
        }
    }
}