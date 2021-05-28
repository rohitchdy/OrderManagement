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
    public class CustomerApiController : ControllerBase
    {
        public OrderContext dbContext = new OrderContext();
        // GET: api/<CategoryApiController>
        [HttpGet]
        [Route("Get")]
        public IActionResult Get()
        {
            int count = (from row in dbContext.customers
                         select row).Count();
            return Ok(count);
        }

        [HttpGet]
        [Route("GetAllCustomer")]
        public IActionResult GetAllCustomers()
        {
            var results = (from row in dbContext.customers
                         select row);
            return Ok(results);
        }

        [HttpGet]
        [Route("GetCustomerDetailsWithTheirOrder/{customerId}")]
        public IActionResult GetCustomerDetailsWithTheirOrder(String customerId)
        {
            var result = (from c in dbContext.customers
                          join
o in dbContext.orders on c.CustomerID equals o.CustomerID
                          join od in dbContext.orderDetails on o.OrderID equals od.OrderID
                          where c.CustomerID == customerId
                          select new
                          {
                             customersDetails= c,
                              order=o,
                              orderDetails=od
                          });
                          
            return Ok(result);
        }

        

        // GET api/<CustomerApiController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CustomerApiController>
        [HttpPost]
        public IActionResult Post([FromBody] Customers customer)
        {
            dbContext.customers.Add(customer);
            dbContext.SaveChanges();
            return Ok("Success");
        }

        // PUT api/<CustomerApiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CustomerApiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
