using BackOfficeApi.Model.Entities;

namespace BackOfficeApi.Service
{
    public interface IDepartmentService
    {
        IEnumerable<Department> GetPagination(int skip, int take);
        int GetCount();
        Department GetById(Guid id);
        void Post(Department department);
        void Update(Department department);
        void Delete(Guid id);
    }
}
