using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using ThemeEmbeding.Models;

namespace ThemeEmbeding.Controllers.api
{
    public class ProductDetailController : ApiController
    {
        ApplicationDbContext Db;
        public ProductDetailController()
        {
            Db = new ApplicationDbContext();
        }

        [HttpGet]
        async public Task<IHttpActionResult> GetProduct(int Id)
        {
            var data = await Db.Products.Where(e => e.Id == Id).Include(e => e.Categories).Include(e => e.Brands).FirstOrDefaultAsync();
            return Ok(data);
        }


    }
}
