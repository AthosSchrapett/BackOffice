using BackOfficeApi.Data.Repositories;
using BackOfficeApi.Data.Repositories.Implementation;
using BackOfficeApi.Data.Repositories.Interfaces;
using BackOfficeApi.Model.Entities;
using BackOfficeApi.Model.Entities.Person;

namespace BackOfficeApi.Data.Infra
{
    public class UnityOfWork: IUnityOfWork
    {
        private IBaseRepository<LegalPerson> _legalPersonRepository;
        private IBaseRepository<NaturalPerson> _naturalPersonRepository;
        private ILegalPersonRepository _legalPersonRepositoryOtherImplementations;
        private INaturalPersonRepository _naturalPersonRepositoryOtherImplementations;
        private IBaseRepository<Department> _departmentRepository;

        private readonly BackOfficeContext _backOfficeContext;

        public UnityOfWork(BackOfficeContext backOfficeContext)
        {
            _backOfficeContext = backOfficeContext;
        }

        public IBaseRepository<LegalPerson> LegalPersonRepository
        {
            get => _legalPersonRepository == null ? new BaseRepository<LegalPerson>(_backOfficeContext) : _legalPersonRepository;
        }

        public ILegalPersonRepository LegalPersonRepositoryOtherImplementations
        {
            get => _legalPersonRepositoryOtherImplementations == null ? new LegalPersonRepository(_backOfficeContext) : _legalPersonRepositoryOtherImplementations;
        }

        public IBaseRepository<NaturalPerson> NaturalPersonRepository
        {
            get => _naturalPersonRepository == null ? new BaseRepository<NaturalPerson>(_backOfficeContext) : _naturalPersonRepository;
        }

        public INaturalPersonRepository NaturalPersonRepositoryOtherImplementations
        {
            get => _naturalPersonRepositoryOtherImplementations == null ? new NaturalPersonRepository(_backOfficeContext) : _naturalPersonRepositoryOtherImplementations;
        }

        public IBaseRepository<Department> DepartmentRepository
        {
            get => _departmentRepository == null ? new BaseRepository<Department>(_backOfficeContext) : _departmentRepository;
        }

        public int Commit() => _backOfficeContext.SaveChanges();

        public void Dispose()
        {
            if(_backOfficeContext != null)
                _backOfficeContext.Dispose();

            GC.SuppressFinalize(this);
        }
    }
}
