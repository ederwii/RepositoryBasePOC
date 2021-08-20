using Domain.DataModels;
using Domain.DTO;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnimalController : ControllerBase
    {
        private readonly IAnimalService _service;

        public AnimalController(IAnimalService service)
        {
            _service = service;
        }

        [HttpPost]
        public ActionResult Create(CreateAnimalRequest request)
        {
            _service.Insert(new Animal() { Name = request.Name });
            return Ok();
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok(_service.Get());
        }
    }
}
