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
    public class EmployeeApiController : ControllerBase
    {
        public OrderContext dbContext = new OrderContext();
        // GET: api/<CategoryApiController>
        [HttpGet]
        [Route("Get")]
        public IActionResult Get()
        {
            int count = (from row in dbContext.employees
                         select row).Count();
            return Ok(count);
        }

        [HttpGet]
        [Route("GetAllEmployee")]
        public IActionResult GetAllEmployee()
        {
            var results =(from row in  dbContext.employees select row);
            return Ok(results);
        }

        // GET api/<EmployeeApiController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EmployeeApiController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmployeeApiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployeeApiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
