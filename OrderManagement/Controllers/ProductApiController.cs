using Microsoft.AspNetCore.Mvc;
using OrderManagement.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OrderManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductApiController : ControllerBase
    {
        public OrderContext dbContext = new OrderContext();
        // GET: api/<ProductApiController>
        [HttpGet]
        [Route("Get")]
        public IActionResult Get()
        {
            int count = (from row in dbContext.products
                         select row).Count();
            return Ok(count);
        }

        [HttpGet]
        [Route("GetAllProduct")]
        public IActionResult GetAllProduct()
        {
            var results = (from row in dbContext.products
                           select row);
            
            return Ok(results);
        }

        // GET api/<ProductApiController>/5
        [HttpGet]
        [Route("ProductByCategoryId/{id}")]
        public IActionResult ProductByCategoryId(int id)
        {
            var result = from i in dbContext.products where i.CategoryID == id select i;
            return Ok(result);
        }

        [HttpGet]
        [Route("GetProductUnitPrice/{id}")]
        public IActionResult GetProductUnitPrice(int id)
        {
            var price = (from p in dbContext.products
                           where p.ProductID == id
                           select p.UnitPrice 
                          );
            return Ok(price);
        }

        // POST api/<ProductApiController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProductApiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductApiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
