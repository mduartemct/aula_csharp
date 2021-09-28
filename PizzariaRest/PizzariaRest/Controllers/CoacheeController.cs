using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzariaRest.Models;
using PizzariaRest.Mocks;

namespace PizzariaRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoacheeController : ControllerBase
    {
        // GET: api/<CoacheeController>
        [HttpGet]
        public List<Coachee> Get()
        {
            return CoacheeMock.ReadCoachees().ToList();
        }

        // GET api/<CoacheeController>/5
        [HttpGet("{id}")]
        public ActionResult<Coachee> Get(string id)
        {
            try
            {
                var ret = CoacheeMock.ReadCoachee(id);

                return Ok(ret);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("404"))
                {
                    return NotFound();
                }
                return BadRequest(ex.Message);

            }

        }

        // POST api/<CoacheeController>
        [HttpPost]
        public IActionResult Post([FromBody] Coachee value)
        {
            try
            {
                if (string.IsNullOrEmpty(value.Name))
                {
                    return Ok("Erro na criação do Coachee");
                    //return BadRequest("Name Nao Pode ser Nulo / Vazio");
                    //throw new SystemException("Name Nao Pode ser Nulo/Vazio");
                }
                var ret = CoacheeMock.CreateCoachee(value.Name, value.Gender, value.Email);
                if (string.IsNullOrEmpty(ret.Id))
                {
                    return NotFound("Erro na criação do Coachee");
                    // throw new SystemException("Erro na criação do Coachee");
                }

                //var result = new CreatedAtActionResult("Post", "coachee", "", new { message = "201 Created", Id = ret.Id });
                //return result;
                //return Created(Get,ret.Id);
                return new OkObjectResult(ret);
            }
            catch (Exception ex)
            {

                //return CreatedAtAction("PostError", null);
                return BadRequest(ex.Message);
                //throw;
            }
        }

        // PUT api/<CoacheeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CoacheeController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            var ret = CoacheeMock.DeleteCoachee(id);
            if (!ret) throw new SystemException("Coachee não existe");
        }
    }
}
