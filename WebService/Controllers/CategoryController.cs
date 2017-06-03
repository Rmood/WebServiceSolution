using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using DomainModel;
using FinurligvisDatabase;
using WebService.Models;
using AutoMapper;

namespace WebService.Controllers
{
    [Route("api/categories")]
    public class CategoryController : Controller
    {
        private readonly IDataService _dataService;

        public CategoryController(IDataService dataService)
        {
            _dataService = dataService;
        }

        [HttpGet]
        public IActionResult GetCategories()
        {
            var data = _dataService.GetCategories();
            //var result = data.Select(x => new ClientListModel {Id = x.Id, Name = x.Name, Description = x.Description});
            var result = Mapper.Map<IEnumerable<CategoryModel>>(data);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetCategory(int id)
        {
            var category = _dataService.GetCategory(id);
            if (category == null) return NotFound();
            //var model = new ClientListModel()
            //{
            //    Id = client.Id,
            //    Name = client.Name,
            //    Description = client.Description
            //};

            var model = Mapper.Map<CategoryListModel>(category);
            return Ok(model);
        }

        [HttpPost]
        public IActionResult CreateCategory([FromBody]CategoryCreateModel model)
        {
            if (model == null) return BadRequest();
            var category = Mapper.Map<Category>(model);
            _dataService.CreateCategory(category);

            return CreatedAtRoute(null, null, Mapper.Map<CategoryModel>(category));
        }


    }
}
