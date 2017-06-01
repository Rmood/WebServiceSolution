using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DomainModel;
using FinurligvisDatabase;

namespace WebService.Controllers
{
    [Route("api/values")]
    public class ValuesController : Controller
    {
        private readonly FinurligvisDataService _dataService;

        public ValuesController()
        {
            _dataService = new FinurligvisDataService();
        }

        // GET api/values
        [HttpGet]
        public IActionResult GetProducts()
        {
            var data = _dataService.GetProducts();
            return Ok(data);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var product = _dataService.GetProduct(id);
            return Ok(product);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
