using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using ThemeEmbeding.Models;

namespace ThemeEmbeding.Controllers.api
{
    public class AddToCartController : ApiController
    {
        ApplicationDbContext Db;
        public AddToCartController()
        {
            Db = new ApplicationDbContext();
        }

        [HttpGet]
        async public Task<IHttpActionResult> Cart(int Id)
        {
            var data = await Db.Products.Where(e => e.Id == Id).FirstOrDefaultAsync();
            LocalCart.LocalProducts.Add(data);
            return Ok();
        }
    }
}
