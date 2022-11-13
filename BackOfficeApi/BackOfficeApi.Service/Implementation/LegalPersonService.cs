using BackOfficeApi.Data.Infra;
using BackOfficeApi.Model.Entities.Person;

namespace BackOfficeApi.Service
{
    public class LegalPersonService : IPersonService<LegalPerson>
    {

        private readonly IUnityOfWork _unityOfWork;

        public LegalPersonService(IUnityOfWork unityOfWork) => _unityOfWork = unityOfWork;

        public void Post(Person person)
        {
            _unityOfWork.LegalPersonRepository.Post((LegalPerson)person);
            _unityOfWork.Commit();
        }

        public Person GetById(Guid id)
        {
            return _unityOfWork.LegalPersonRepository.GetById(id);
        }

        public int GetCount()
        {
            return _unityOfWork.LegalPersonRepository.GetCount();
        }

        public IEnumerable<Person> GetPagination(int skip, int take)
        {
            return _unityOfWork.LegalPersonRepository.GetPagination(skip, take);
        }

        public void Update(Person person)
        {
            _unityOfWork.LegalPersonRepository.Update((LegalPerson)person);
            _unityOfWork.Commit();
        }

        public void Delete(Guid id)
        {
            _unityOfWork.LegalPersonRepository.Delete(id);
            _unityOfWork.Commit();
        }
    }
}
