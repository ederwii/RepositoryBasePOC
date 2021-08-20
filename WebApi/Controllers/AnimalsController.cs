using Domain.DTO;
using Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        private readonly IAnimalService _service;

        public AnimalsController(IAnimalService service)
        {
            _service = service;
        }

        [HttpPost]
        public ActionResult Create(CreateAnimalRequest request)
        {
            _service.Insert(new Domain.DataModels.Animal()
            {
                Name = request.Name
            });
            return Ok();
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_service.Get());
        }
    }
}
