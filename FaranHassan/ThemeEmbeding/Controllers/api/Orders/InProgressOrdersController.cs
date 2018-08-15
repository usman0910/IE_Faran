using Newtonsoft.Json;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using ThemeEmbeding.Locals;
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


            var inProgressOrders = new List<NewOrders>();

            var dataDeSerilized = new List<Products>();
            foreach (var item in data)
            {
                dataDeSerilized = JsonConvert.DeserializeObject<List<Products>>(item.CartDetails);

                var order = new NewOrders()
                {
                    Id = item.Id,
                    CustomerId = item.CustomerId,
                    Date = item.Date,
                    Products = dataDeSerilized,
                    OrderStatusId = item.OrderStatusId

                };
                inProgressOrders.Add(order);
            }

            return Ok(inProgressOrders);
        }
    }
}
