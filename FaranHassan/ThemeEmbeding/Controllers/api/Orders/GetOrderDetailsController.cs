using Newtonsoft.Json;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using ThemeEmbeding.Models;
using ThemeEmbeding.ViewModels;

namespace ThemeEmbeding.Controllers.api.Orders
{
    public class GetOrderDetailsController : ApiController
    {
        ApplicationDbContext Db;
        public GetOrderDetailsController()
        {
            Db = new ApplicationDbContext();
        }

        [HttpGet]
        async public Task<IHttpActionResult> GetDetails(int Id)
        {
            var data = await Db.Orders.Where(e => e.Id == Id).Include(e => e.Customer).FirstOrDefaultAsync();



            var dataDeSerilized = new List<Products>();
            dataDeSerilized = JsonConvert.DeserializeObject<List<Products>>(data.CartDetails);

            var order = new OrderDetailsVM()
            {
                Customer = data.Customer,
                Products = dataDeSerilized

            };

            return Ok(order);
        }
    }
}
