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
        // GET: api/Cocahee
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Cocahee/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Cocahee
        [HttpPost]
        public ActionResult<Coachee> Post([FromBody] Coachee value)
        {
            try
            {
                var ret = CoacheeMock.CreateCoachee(value.Name, value.Gender);
                if (string.IsNullOrEmpty(ret.Id))
                {
                    throw new SystemException("Erro na Criação do Coachee");
                }
                return CreatedAtAction("Post", ret.Id);
            }
            catch (Exception)
            {
                //return CreatedAtAction("PostError", null);
                return BadRequest(value);
            }

            //return ret;
        }

        // PUT: api/Cocahee/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Cocahee/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
