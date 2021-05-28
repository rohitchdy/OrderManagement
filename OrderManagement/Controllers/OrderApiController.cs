using Microsoft.AspNetCore.Mvc;
using OrderManagement.DataAccess;
using OrderManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OrderManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderApiController : ControllerBase
    {
        
        public OrderContext dbContext = new OrderContext();
        // GET: api/<CategoryApiController>
        [HttpGet]
        [Route("Get")]
        public IActionResult Get()
        {
            int count = (from row in dbContext.orders
                         select row).Count();
            return Ok(count);
        }

        [Route("GetAllOrder")]
        public IActionResult GetAllOrder()
        {
            var results = (from row in dbContext.orders
                         select row);
            return Ok(results);
        }

        [HttpGet]
        [Route("GetLastOrderID")]
        public IActionResult GetLastOrderID()
        {
            var result = (from o in dbContext.orders orderby o.OrderID descending select o.OrderID).First();
            return Ok(result);
        }

        // GET api/<OrderApiController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<OrderApiController>
        [HttpPost]
        public IActionResult Post([FromBody] Orders order)
        {
            
            
            dbContext.orders.Add(order);
            dbContext.SaveChanges();

            return Ok("Order success");
        }

        // PUT api/<OrderApiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<OrderApiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
