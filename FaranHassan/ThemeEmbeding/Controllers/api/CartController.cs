using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using ThemeEmbeding.Models;
using ThemeEmbeding.ViewModels;

namespace ThemeEmbeding.Controllers.api
{
    public class CartController : ApiController
    {

        [HttpGet]
        async public Task<IHttpActionResult> MyCart()
        {

            var cart = new CartProductsVM()
            {
                Products = LocalCart.LocalProducts.ToList(),
                TotalPrice = LocalCart.LocalProducts.ToList().Sum(e => e.Price)
            };
            return Ok(cart);
        }
    }
}
