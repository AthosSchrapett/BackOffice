using BackOfficeApi.Data.Infra;
using BackOfficeApi.Model.Entities.Person;

namespace BackOfficeApi.Service
{
    public class NaturalPersonService : IPersonService<NaturalPerson>
    {
        private readonly IUnityOfWork _unityOfWork;

        public NaturalPersonService(IUnityOfWork unityOfWork) => _unityOfWork = unityOfWork;

        public void Post(Person person)
        {
            _unityOfWork.NaturalPersonRepository.Post((NaturalPerson)person);
            _unityOfWork.Commit();
        }

        public Person GetById(Guid id)
        {
            return _unityOfWork.NaturalPersonRepository.GetById(id);
        }

        public int GetCount()
        {
            return _unityOfWork.NaturalPersonRepository.GetCount();
        }

        public IEnumerable<Person> GetPagination(int skip, int take)
        {
            return _unityOfWork.NaturalPersonRepository.GetPagination(skip, take);
        }

        public void Update(Person person)
        {
            _unityOfWork.NaturalPersonRepository.Update((NaturalPerson)person);
            _unityOfWork.Commit();
        }

        public void Delete(Guid id)
        {
            _unityOfWork.NaturalPersonRepository.Delete(id);
            _unityOfWork.Commit();
        }
    }
}
