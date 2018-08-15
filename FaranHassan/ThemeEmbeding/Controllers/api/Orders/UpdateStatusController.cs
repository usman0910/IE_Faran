using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using ThemeEmbeding.Models;

namespace ThemeEmbeding.Controllers.api.Orders
{
    public class UpdateStatusController : ApiController
    {
        ApplicationDbContext Db;
        public UpdateStatusController()
        {
            Db = new ApplicationDbContext();
        }

        [HttpGet]
        async public Task<IHttpActionResult> ChangeStatus(int Id)
        {
            var data = await Db.Orders.Where(e => e.Id == Id).FirstOrDefaultAsync();

            if (data.OrderStatusId == 1)
            {
                data.OrderStatusId = 2;
            }
            else if (data.OrderStatusId == 2)
            {
                data.OrderStatusId = 5;
            }
            await Db.SaveChangesAsync();
            return Ok();
        }
    }
}
