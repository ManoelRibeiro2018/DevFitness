using DevFitness.API.Models.InputModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFitness.API.Controllers
{
    [Route("api/users/{idUSer}/meals")]
    public class MaelsController: ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll(int idUser)
        {
            return Ok();
        }

        [HttpGet("{idMeals}")]
        public IActionResult Get(int idUser, int idMeals)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Post(int idUser, [FromBody] CreateMealInputModel model)
        {
            return Ok();
        }


        [HttpPut("{idMeals}")]
        public IActionResult Put(int idUSer, int idMeals, [FromBody] UpdateMealInputModel model)
        {
            return NoContent();
        }

        [HttpDelete("{idMeals}")]
        public IActionResult Delte(int idUser, int idMeals)
        {
            return NoContent();
        }
    }

}
