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
    public class NewOrdersController : ApiController
    {
        ApplicationDbContext Db;
        public NewOrdersController()
        {
            Db = new ApplicationDbContext();
        }

        [HttpGet]
        async public Task<IHttpActionResult> ViewAll()
        {
            var data = await Db.Orders.Where(e => e.OrderStatusId == 1).ToListAsync();


            var newOrders = new List<NewOrders>();

            var dataDeSerilized = new List<Products>();
            foreach (var item in data)
            {
                dataDeSerilized = JsonConvert.DeserializeObject<List<Products>>(item.CartDetails);

                var order = new NewOrders()
                {
                    CustomerId = item.CustomerId,
                    Date = item.Date,
                    Products = dataDeSerilized,
                    OrderStatusId = item.OrderStatusId

                };
                newOrders.Add(order);
            }

            return Ok(newOrders);
        }
    }
}
