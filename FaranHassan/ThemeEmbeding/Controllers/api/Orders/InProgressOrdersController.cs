using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using ThemeEmbeding.Models;

namespace ThemeEmbeding.Controllers.api.Orders
{
    public class InProgressOrdersController : ApiController
    {
        ApplicationDbContext Db;
        public InProgressOrdersController()
        {
            Db = new ApplicationDbContext();
        }

        [HttpGet]
        async public Task<IHttpActionResult> ViewAll()
        {
            var data = await Db.Orders.Where(e => e.OrderStatusId == 2).ToListAsync();
            return Ok(data);
        }
    }
}
