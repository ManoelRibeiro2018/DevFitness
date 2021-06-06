using DevFitness.API.Models.InputModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFitness.API.Controllers
{
    [Route("api/users")]
    public class UserController: ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateUserInputModel model)
        {
            return CreatedAtAction(nameof(Get), new {id = 10 } , model);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id,[FromBody] UpdateUserInputModel model)
        {
            return NoContent();
        }
    }
}
