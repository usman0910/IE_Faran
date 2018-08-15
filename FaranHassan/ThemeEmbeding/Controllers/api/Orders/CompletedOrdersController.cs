using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using ThemeEmbeding.Models;

namespace ThemeEmbeding.Controllers.api.Orders
{
    public class CompletedOrdersController : ApiController
    {
        ApplicationDbContext Db;
        public CompletedOrdersController()
        {
            Db = new ApplicationDbContext();
        }

        [HttpGet]
        async public Task<IHttpActionResult> ViewAll()
        {
            var data = await Db.Orders.Where(e => e.OrderStatusId == 5).ToListAsync();
            return Ok(data);
        }
    }
}
