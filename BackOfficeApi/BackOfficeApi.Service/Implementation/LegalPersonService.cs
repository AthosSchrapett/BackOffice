using BackOfficeApi.Data.Infra;
using BackOfficeApi.Model.Entities.Person;

namespace BackOfficeApi.Service
{
    public class LegalPersonService : ILegalPersonService
    {

        private readonly IUnityOfWork _unityOfWork;

        public LegalPersonService(IUnityOfWork unityOfWork) => _unityOfWork = unityOfWork;

        public void Post(LegalPerson legalPerson)
        {
            _unityOfWork.LegalPersonRepository.Post(legalPerson);
            _unityOfWork.Commit();
        }

        public bool getPersonByDocumentOrName(string cnpj, string name)
        {
            return _unityOfWork.LegalPersonRepositoryOtherImplementations.getPersonByDocumentOrName(cnpj, name);
        }

        public LegalPerson GetById(Guid id)
        {
            return _unityOfWork.LegalPersonRepository.GetById(id);
        }

        public int GetCount()
        {
            return _unityOfWork.LegalPersonRepository.GetCount();
        }

        public IEnumerable<LegalPerson> GetPagination(int skip, int take)
        {
            return _unityOfWork.LegalPersonRepository.GetPagination(skip, take);
        }

        public void Update(LegalPerson legalPerson)
        {
            _unityOfWork.LegalPersonRepository.Update(legalPerson);
            _unityOfWork.Commit();
        }

        public void Delete(Guid id)
        {
            _unityOfWork.LegalPersonRepository.Delete(id);
            _unityOfWork.Commit();
        }
    }
}
