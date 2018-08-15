using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using ThemeEmbeding.Models;

namespace ThemeEmbeding.Controllers.api
{
    public class RemoveFromCartController : ApiController
    {
        [HttpGet]
        async public Task<IHttpActionResult> Cart(int Id)
        {
            var data = LocalCart.LocalProducts.FirstOrDefault(e => e.Id == Id);
            LocalCart.LocalProducts.Remove(data);
            return Ok();
        }
    }
}
