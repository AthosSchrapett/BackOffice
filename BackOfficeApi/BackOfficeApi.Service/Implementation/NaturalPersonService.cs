using BackOfficeApi.Data.Infra;
using BackOfficeApi.Model.Entities.Person;

namespace BackOfficeApi.Service
{
    public class NaturalPersonService : INaturalPersonService
    {
        private readonly IUnityOfWork _unityOfWork;

        public NaturalPersonService(IUnityOfWork unityOfWork) => _unityOfWork = unityOfWork;

        public void Post(NaturalPerson naturalPerson)
        {
            _unityOfWork.NaturalPersonRepository.Post(naturalPerson);
            _unityOfWork.Commit();
        }

        public bool getPersonByDocumentOrName(string cpf, string name)
        {
            return _unityOfWork.NaturalPersonRepositoryOtherImplementations.getPersonByDocumentOrName(cpf, name);
        }

        public NaturalPerson GetById(Guid id)
        {
            return _unityOfWork.NaturalPersonRepository.GetById(id);
        }

        public IEnumerable<NaturalPerson> GetAll()
        {
            return _unityOfWork.NaturalPersonRepositoryOtherImplementations.GetAll();
        }

        public int GetCount()
        {
            return _unityOfWork.NaturalPersonRepository.GetCount();
        }

        public IEnumerable<NaturalPerson> GetPagination(int skip, int take)
        {
            return _unityOfWork.NaturalPersonRepository.GetPagination(skip, take);
        }

        public void Update(NaturalPerson naturalPerson)
        {
            _unityOfWork.NaturalPersonRepository.Update(naturalPerson);
            _unityOfWork.Commit();
        }

        public void Delete(Guid id)
        {
            _unityOfWork.NaturalPersonRepository.Delete(id);
            _unityOfWork.Commit();
        }
    }
}
