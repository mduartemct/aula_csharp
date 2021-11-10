using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzariaRest.Models;
using PizzariaRest.Mocks;
using PizzariaRest.Repositories;

namespace PizzariaRest.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AgreementController : ControllerBase
    {
        private AgreementRepository agreementRepository;

        public AgreementController()
        {
            agreementRepository = new AgreementRepository();
        }


        // GET: api/<CoacheeController>
        [HttpGet]
        public ActionResult<List<Agreement>> Get()
        {
            try
            {
                List<Agreement> result = agreementRepository.AgreementQueryable().ToList();
                if (result.Count == 0)
                {
                    return StatusCode(204);
                }
                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }

        }

        // GET api/<CoacheeController>/5
        [HttpGet("{id}")]
        public ActionResult<Agreement> Get(string id)
        {
            try
            {
                var ret = agreementRepository.Read(id);

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
        public IActionResult Post([FromBody] Agreement agreement)
        {
            try
            {
                if (string.IsNullOrEmpty(agreement.Description))
                {
                    return BadRequest("Name Nao Pode ser Nulo / Vazio");
                }
                var ret = agreementRepository.Create(agreement);

                if (string.IsNullOrEmpty(ret.Id))
                {
                    return NotFound("Erro na criação do Agreement");
                }

                return new OkObjectResult(ret);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<CoacheeController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] Agreement agreement)
        {
            if (id.Contains("171"))
            {
                throw new ArgumentException($"Id de malandro....Passa o Id correto animal!", nameof(agreement));
            }


            var ret = agreementRepository.Update(id, agreement);
            if (!ret)
            {
                return StatusCode(422);
            }
            return StatusCode(204);
        }

        // DELETE api/<CoacheeController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var ret = agreementRepository.Delete(id);
            if (!ret)
                return StatusCode(422);

            return StatusCode(204);

        }
    }
}
