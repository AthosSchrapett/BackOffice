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
        private readonly ILegalPersonService _legalPersonService;

        public LegalPersonController(ILegalPersonService legalPersonService)
        {
            _legalPersonService = legalPersonService;
        }

        [HttpGet]
        public ActionResult GetPaginationLegalPerson(int skip, int take)
        {
            List<LegalPerson> legalPersons = _legalPersonService.GetPagination(skip, take).ToList();

            return Ok(legalPersons);
        }

        [HttpGet("count")]
        public ActionResult GetCount()
        {
            int countLegalPerson = _legalPersonService.GetCount();

            return Ok(new { totalLegalPerson = countLegalPerson });
        }

        [HttpGet("{id}")]
        public ActionResult GetById(Guid id)
        {
            LegalPerson legalPerson = _legalPersonService.GetById(id);

            return Ok(legalPerson);
        }

        [HttpPost]
        public ActionResult PostLegalPerson([FromBody]LegalPerson legalPerson)
        {
            if (_legalPersonService.getPersonByDocumentOrName(legalPerson.Cnpj, legalPerson.Nome))
                return BadRequest("CNPJ ou Nome já cadastrado.");

            _legalPersonService.Post(legalPerson);

            return Ok(legalPerson);
        }

        [HttpPut]
        public ActionResult UpdateLegalPerson([FromBody] LegalPerson legalPerson)
        {
            _legalPersonService.Update(legalPerson);

            return Ok(legalPerson);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            _legalPersonService.Delete(id);

            return Ok("Registro excluído com sucesso");
        }
    }
}
