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
    public class ProductController : ApiController
    {
        ApplicationDbContext Db;
        public ProductController()
        {
            Db = new ApplicationDbContext();
        }

        [HttpGet]
        async public Task<IHttpActionResult> ViewAll()
        {
            var data = await Db.Products.Include(e => e.Categories).ToListAsync();
            return Ok(data);
        }
        
        [HttpGet]
        async public Task<IHttpActionResult> ViewAllCategoryProducts(int Id)
        {

            return Ok(await Db.Products.Where(e => e.CategoryId == Id).Include(e => e.Categories).ToListAsync());
        }

        [HttpPost]
        async public Task<IHttpActionResult> New(Products product)
        {
            Db.Products.Add(product);
            await Db.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete]
        async public Task<IHttpActionResult> Delete(int Id)
        {
            var product = await Db.Products.SingleOrDefaultAsync(e => e.Id == Id);
            Db.Products.Remove(product);
            await Db.SaveChangesAsync();
            return Ok();
        }
    }
}
