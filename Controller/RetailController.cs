using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApp.Data;
using MyApp.Models;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class RetailController : ControllerBase
    {
        private readonly MyAppDbContext context;

        public RetailController(MyAppDbContext _context) 
        {
            context = _context;
        }

        // GET: api/<RetailController>
        [HttpGet]
        public List<Item> Get()
        {
            return context.Items.ToList();
        }

        // GET api/<RetailController>/5
        [HttpGet("{id}")]
        public Item Get(int id)
        {
            return context.Items.Find(id);

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
            Item item = context.Items.Find(id);
            context.Remove(item);
            context.SaveChanges();
        }
    }
}
