using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class RetailController : ControllerBase
    {
        // // GET: api/<RetailController>
        // [HttpGet]
        // public IActionResult Get()
        // {
        //     // string[] collection = new string[] { "value1", "value2" }
        //     return Content("a");
        // }

        // GET: api/<RetailController>
        [HttpGet]
        public string[] Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<RetailController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RetailController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<RetailController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RetailController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
