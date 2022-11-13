using BackOfficeApi.Model.Entities.Person;
using BackOfficeApi.Model.Enums;
using BackOfficeApi.Service;
using Microsoft.AspNetCore.Mvc;

namespace BackOfficeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LegalPersonController : ControllerBase
    {
        private readonly IPersonService<LegalPerson> _personService;

        public LegalPersonController(IPersonService<LegalPerson> personService)
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
        public ActionResult PostLegalPerson([FromBody]LegalPerson legalPerson)
        {
            _personService.Post(legalPerson);

            return Ok(legalPerson);
        }

        [HttpPut]
        public ActionResult UpdateLegalPerson([FromBody] LegalPerson legalPerson)
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
