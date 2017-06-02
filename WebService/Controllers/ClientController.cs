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
    [Route("api/clients")]
    public class ClientController : Controller
    {
        private readonly IDataService _dataService;

        public ClientController(IDataService dataService)
        {
            _dataService = dataService;
        }

        [HttpGet]
        public IActionResult GetClients()
        {
            var data = _dataService.GetClients();
            //var result = data.Select(x => new ClientListModel {Id = x.Id, Name = x.Name, Description = x.Description});
            var result = Mapper.Map<IEnumerable<ClientModel>>(data);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetClient(int id)
        {
            var client = _dataService.GetClient(id);
            if (client == null) return NotFound();
            //var model = new ClientListModel()
            //{
            //    Id = client.Id,
            //    Name = client.Name,
            //    Description = client.Description
            //};

            var model = Mapper.Map<ClientListModel>(client);
            return Ok(model);
        }

        [HttpPost]
        public IActionResult CreateClient([FromBody]ClientCreateModel model)
        {
            if (model == null) return BadRequest();
            var client = Mapper.Map<Client>(model);
            _dataService.CreateClient(client);

            return CreatedAtRoute(null, null, Mapper.Map<ClientModel>(client));
        }


    }
}
