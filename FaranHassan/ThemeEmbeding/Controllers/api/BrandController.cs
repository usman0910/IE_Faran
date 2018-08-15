using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using ThemeEmbeding.Models;

namespace ThemeEmbeding.Controllers.api
{
    public class BrandController : ApiController
    {
        ApplicationDbContext Db;
        public BrandController()
        {
            Db = new ApplicationDbContext();
        }
        [HttpGet]
        async public Task<IHttpActionResult> ViewAll()
        {
            return Ok(await Db.Brands.Include(e => e.Categories).ToListAsync());
        }

        [HttpGet]
        async public Task<IHttpActionResult> ViewAllBrandsWithCategories(int Id)
        {
            return Ok(await Db.Brands.Where(e => e.CategoryId == Id).Include(e => e.Categories).ToListAsync());
        }

        [HttpPost]
        async public Task<IHttpActionResult> New(Brands brand)
        {
            Db.Brands.Add(brand);
            await Db.SaveChangesAsync();
            return Ok();
        }
        [HttpDelete]
        async public Task<IHttpActionResult> Delete(int Id)
        {
            var brand = await Db.Brands.SingleOrDefaultAsync(e => e.Id == Id);
            Db.Brands.Remove(brand);
            await Db.SaveChangesAsync();
            return Ok();
        }
    }
}
