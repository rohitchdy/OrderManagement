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
    public class OrderDetailApiController : ControllerBase
    {
        public OrderContext dbContext = new OrderContext();

        // GET: api/<OdereDetailApiController>
        [HttpGet]
        public IActionResult Get()
        {
            var results = from od in dbContext.orderDetails select od;
            return Ok(results);
        }

        // GET api/<OdereDetailApiController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public IActionResult Post([FromBody] OrderDetails orderDetails)
        {
            dbContext.orderDetails.Add(orderDetails);
            dbContext.SaveChanges();
            return Ok("order success");
        }

        // PUT api/<OdereDetailApiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<OdereDetailApiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
