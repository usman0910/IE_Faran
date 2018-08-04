using System.Data.Entity;
using System.Threading.Tasks;
using System.Web.Http;
using ThemeEmbeding.Models;

namespace ThemeEmbeding.Controllers.api
{
    public class CategoryController : ApiController
    {
        ApplicationDbContext Db;
        public CategoryController()
        {
            Db = new ApplicationDbContext();
        }
        [HttpGet]
        async public Task<IHttpActionResult> ViewAll()
        {
            return Ok(await Db.Categories.ToListAsync());
        }
        [HttpPost]
        async public Task<IHttpActionResult> New(Categories category)
        {
            Db.Categories.Add(category);
            await Db.SaveChangesAsync();
            return Ok();
        }
        [HttpDelete]
        async public Task<IHttpActionResult> Delete(int Id)
        {
            var category = await Db.Categories.SingleOrDefaultAsync(e => e.Id == Id);
            Db.Categories.Remove(category);
            await Db.SaveChangesAsync();
            return Ok();
        }
    }

}
