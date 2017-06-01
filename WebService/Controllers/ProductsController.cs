using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using DomainModel;
using FinurligvisDatabase;
using WebService.Models;

namespace WebService.Controllers
{
    [Route("api/products")]
    public class ProductsController : Controller
    {
        private readonly IDataService _dataService;

        public ProductsController(IDataService dataService)
        {
            _dataService = dataService;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            var data = _dataService.GetProducts();
            var result = data.Select(x => new ProductListModel {Id = x.Id, Name = x.Name, Description = x.Description});
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var product = _dataService.GetProduct(id);
            if (product == null) return NotFound();
            var model = new ProductListModel()
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description
            };
            return Ok(model);
        }

        
    }
}
