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
    public class RegionApiController : ControllerBase
    {
        public OrderContext dbContext = new OrderContext();
        
        [HttpGet]
        [Route("Get")]
        public IActionResult Get()
        {
            var result = (from row in dbContext.regions
                          select row);
            return Ok(result);
        }

        // GET api/<RegionApiController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RegionApiController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<RegionApiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RegionApiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
