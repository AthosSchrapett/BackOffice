using BackOfficeApi.Data.Repositories;
using BackOfficeApi.Model.Entities;
using BackOfficeApi.Model.Entities.Person;

namespace BackOfficeApi.Data.Infra
{
    public interface IUnityOfWork : IDisposable
    {
        IBaseRepository<LegalPerson> LegalPersonRepository { get; }
        IBaseRepository<NaturalPerson> NaturalPersonRepository { get; }
        IBaseRepository<Department> DepartmentRepository { get; }
        int Commit();
    }
}
