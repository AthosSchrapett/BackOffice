using BackOfficeApi.Data.Repositories;
using BackOfficeApi.Data.Repositories.Interfaces;
using BackOfficeApi.Model.Entities;
using BackOfficeApi.Model.Entities.Person;

namespace BackOfficeApi.Data.Infra
{
    public interface IUnityOfWork : IDisposable
    {
        IBaseRepository<LegalPerson> LegalPersonRepository { get; }
        ILegalPersonRepository LegalPersonRepositoryOtherImplementations { get; }
        IBaseRepository<NaturalPerson> NaturalPersonRepository { get; }
        INaturalPersonRepository NaturalPersonRepositoryOtherImplementations { get; }
        IBaseRepository<Department> DepartmentRepository { get; }
        int Commit();
    }
}
