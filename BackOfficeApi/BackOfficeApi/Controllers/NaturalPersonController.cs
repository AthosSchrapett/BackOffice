using BackOfficeApi.Model.Entities.Person;
using BackOfficeApi.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackOfficeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NaturalPersonController : ControllerBase
    {
        private readonly IPersonService<NaturalPerson> _personService;

        public NaturalPersonController(IPersonService<NaturalPerson> personService)
        {
            _personService = personService;
        }

        [HttpGet]
        public ActionResult GetPaginationLegalPerson(int skip, int take)
        {
            List<Person> persons = _personService.GetPagination(skip, take).ToList();

            return Ok(persons);
        }

        [HttpGet("count")]
        public ActionResult GetCount()
        {
            int countPerson = _personService.GetCount();

            return Ok(new { totalPerson = countPerson });
        }

        [HttpGet("{id}")]
        public ActionResult GetById(Guid id)
        {
            Person person = _personService.GetById(id);

            return Ok(person);
        }

        [HttpPost]
        public ActionResult PostLegalPerson([FromBody] NaturalPerson legalPerson)
        {
            _personService.Post(legalPerson);

            return Ok(legalPerson);
        }

        [HttpPut]
        public ActionResult UpdateLegalPerson([FromBody] NaturalPerson legalPerson)
        {
            _personService.Update(legalPerson);

            return Ok(legalPerson);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            _personService.Delete(id);

            return Ok("Registro excluído com sucesso");
        }
    }
}
