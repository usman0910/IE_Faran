using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using ThemeEmbeding.Models;

namespace ThemeEmbeding.Controllers.api
{
    public class StockController : ApiController
    {
        ApplicationDbContext Db;
        public StockController()
        {
            Db = new ApplicationDbContext();
        }

        [HttpGet]
        async public Task<IHttpActionResult> ViewAll()
        {
            return Ok(await Db.Products.Include(e => e.Categories).ToListAsync());
        }

        [HttpGet]
        async public Task<IHttpActionResult> ViewAllCategoryProducts(int Id)
        {

            return Ok(await Db.Products.Where(e => e.CategoryId == Id).Include(e => e.Categories).ToListAsync());
        }

        [HttpPost]
        async public Task<IHttpActionResult> New(StockIn stockIn)
        {
            var product = await Db.Products.SingleOrDefaultAsync(e => e.Id == stockIn.ProductId);
            product.TotalQuantity = product.TotalQuantity + stockIn.Quantity;

            Db.StockIns.Add(stockIn);
            await Db.SaveChangesAsync();
            return Ok();
        }


    }
}
