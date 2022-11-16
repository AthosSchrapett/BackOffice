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
        private readonly INaturalPersonService _naturalPersonService;

        public NaturalPersonController(INaturalPersonService naturalPersonService)
        {
            _naturalPersonService = naturalPersonService;
        }

        [HttpGet]
        public ActionResult GetPaginationNaturalPerson(int skip, int take)
        {
            List<NaturalPerson> naturalPersons = _naturalPersonService.GetPagination(skip, take).ToList();

            return Ok(naturalPersons);
        }

        [HttpGet("GetAll")]
        public ActionResult GetAll()
        {
            List<NaturalPerson> naturalPersons = _naturalPersonService.GetAll().ToList();

            return Ok(naturalPersons);
        }

        [HttpGet("count")]
        public ActionResult GetCount()
        {
            int countNatualPerson = _naturalPersonService.GetCount();

            return Ok(new { totalPerson = countNatualPerson });
        }

        [HttpGet("{id}")]
        public ActionResult GetById(Guid id)
        {
            Person person = _naturalPersonService.GetById(id);

            return Ok(person);
        }

        [HttpPost]
        public ActionResult PostNaturalPerson([FromBody] NaturalPerson naturalPerson)
        {
            if (_naturalPersonService.getPersonByDocumentOrName(naturalPerson.Cpf, naturalPerson.Nome))
                return BadRequest("CPF ou Nome já cadastrado.");

            _naturalPersonService.Post(naturalPerson);

            return Ok(naturalPerson);
        }

        [HttpPut]
        public ActionResult UpdateNaturalPerson([FromBody] NaturalPerson naturalPerson)
        {
            _naturalPersonService.Update(naturalPerson);

            return Ok(naturalPerson);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            _naturalPersonService.Delete(id);

            return Ok("Registro excluído com sucesso");
        }
    }
}
