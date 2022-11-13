using BackOfficeApi.Model.Entities.Person;
using BackOfficeApi.Model.Enums;

namespace BackOfficeApi.Service
{
    public interface IPersonService<T>
    {
        IEnumerable<Person> GetPagination(int skip, int take);
        int GetCount();
        Person GetById(Guid id);
        void Post(Person person);
        void Update(Person person);
        void Delete(Guid id);
    }
}
