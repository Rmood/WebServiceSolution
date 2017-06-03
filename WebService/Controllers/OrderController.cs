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
    [Route("api/orders")]
    public class OrderController : Controller
    {
        private readonly IDataService _dataService;

        public OrderController(IDataService dataService)
        {
            _dataService = dataService;
        }

        [HttpGet]
        public IActionResult GetOrders()
        {
            var data = _dataService.GetOrders();
            //var result = data.Select(x => new OrderListModel {Id = x.Id, Name = x.Name, Description = x.Description});
            var result = Mapper.Map<IEnumerable<OrderModel>>(data);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetOrder(int id)
        {
            var client = _dataService.GetClient(id);
            if (client == null) return NotFound();
            //var model = new OrderListModel()
            //{
            //    Id = client.Id,
            //    Name = client.Name,
            //    Description = client.Description
            //};

            var model = Mapper.Map<OrderListModel>(client);
            return Ok(model);
        }

        [HttpPost]
        public IActionResult CreateOrder([FromBody]OrderCreateModel model)
        {
            if (model == null) return BadRequest();
            var order = Mapper.Map<Order>(model);
            _dataService.CreateOrder(order);

            return CreatedAtRoute(null, null, Mapper.Map<OrderModel>(order));
        }


    }
}
