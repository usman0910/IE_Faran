using Newtonsoft.Json;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using ThemeEmbeding.Models;

namespace ThemeEmbeding.Controllers.api
{
    public class ConfirmOrderController : ApiController
    {
        ApplicationDbContext Db;
        public ConfirmOrderController()
        {
            Db = new ApplicationDbContext();
        }


        [HttpPost]
        async public Task<IHttpActionResult> New(Customer customer)
        {

            Db.Customers.Add(customer);
            await Db.SaveChangesAsync();

            var DbCustomer = Db.Customers.Where(e => e.Email == customer.Email).FirstOrDefault();

            var products = LocalCart.LocalProducts;
            var cartDetails = JsonConvert.SerializeObject(products);
            Order order = new Order()
            {
                OrderStatusId = 1,
                CartDetails = cartDetails,
                CustomerId = DbCustomer.Id,
                Date = DateTime.Now

            };

            Db.Orders.Add(order);

            await Db.SaveChangesAsync();

            LocalCart.LocalProducts.Clear();

            return Ok();
        }
    }
}
