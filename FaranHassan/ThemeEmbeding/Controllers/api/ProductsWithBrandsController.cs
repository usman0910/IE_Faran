using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using ThemeEmbeding.Models;

namespace ThemeEmbeding.Controllers.api
{
    public class ProductsWithBrandsController : ApiController
    {
        ApplicationDbContext Db;
        public ProductsWithBrandsController()
        {
            Db = new ApplicationDbContext();
        }

        [HttpGet]
        async public Task<IHttpActionResult> ViewAllBrandProducts(int Id)
        {
            return Ok(await Db.Products.Where(e => e.BrandId == Id).Include(e => e.Categories).Include(e => e.Brands).ToListAsync());
        }
    }
}
