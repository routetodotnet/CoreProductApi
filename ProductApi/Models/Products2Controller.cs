using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductApi.Models
{
    [Route("api/[controller]")]
    [ApiController]
    public class Products2Controller : ControllerBase
    {
        // GET: api/<Products2Controller>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            var prods = new Product[] {

               new Product(){ id=1,name="laptop",desc="mac white"},
                new Product(){ id=2,name="phone",desc="samsung"},
                new Product(){ id=3,name="tennies",desc="rocket"}
            };
            return prods;
        }

        // GET api/<Products2Controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Products2Controller>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Products2Controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Products2Controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
