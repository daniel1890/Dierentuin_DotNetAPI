using Dierentuin_DotNetAPI.Models;
using Dierentuin_DotNetAPI.Services.Dieren;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dierentuin_DotNetAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DierController : ControllerBase
    {
        private readonly IDierService _dierService;

        public DierController(IDierService dierService)
        {
            _dierService = dierService;
        }

        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            return Ok(_dierService.GetAllDieren());
        }

        [HttpGet("{id}")]
        public IActionResult GetSingle(int id)
        {
            return Ok(_dierService.GetDierById(id));
        }

        [HttpPost("AddDier")]
        public IActionResult AddDier(Dier newdier)
        {
            return Ok(_dierService.AddDier(newdier));
        }

        [HttpPut("UpdateDier")]
        public IActionResult UpdateDier(Dier updatedDier)
        {
            return Ok(_dierService.UpdateDier(updatedDier));
        }
    }
}