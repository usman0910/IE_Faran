using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using ThemeEmbeding.Models;

namespace ThemeEmbeding.Controllers.api
{
    public class CartController : ApiController
    {

        [HttpGet]
        async public Task<IHttpActionResult> MyCart()
        {
            var data = LocalCart.LocalProducts.ToList();
            return Ok(data);
        }
    }
}
