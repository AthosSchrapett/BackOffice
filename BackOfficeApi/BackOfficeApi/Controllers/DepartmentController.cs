using BackOfficeApi.Model.Entities;
using BackOfficeApi.Service;
using Microsoft.AspNetCore.Mvc;

namespace BackOfficeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpGet]
        public ActionResult GetPaginationDepartment(int skip, int take)
        {
            List<Department> departments = _departmentService.GetPagination(skip, take).ToList();

            if(departments.Count() <= 0)
                return NotFound("Nenhum registro encontrado");

            return Ok(departments);
        }

        [HttpGet("count")]
        public ActionResult GetCount()
        {
            int countDepartment = _departmentService.GetCount();

            return Ok(new { totalDepartment = countDepartment });
        }

        [HttpGet("{id}")]
        public ActionResult GetById(Guid id)
        {
            Department department = _departmentService.GetById(id);

            if (department == null)
                return NotFound("Nenhum registro encontrado");

            return Ok(department);
        }

        [HttpPost]
        public ActionResult PostLegalDepartment([FromBody] Department department)
        {
            _departmentService.Post(department);

            return Ok(department);
        }

        [HttpPut]
        public ActionResult UpdateLegalDepartment([FromBody] Department department)
        {
            _departmentService.Update(department);

            return Ok(department);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            _departmentService.Delete(id);

            return Ok("Registro excluído com sucesso");
        }
    }
}
