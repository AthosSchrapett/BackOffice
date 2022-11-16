using BackOfficeApi.Model.Entities.Person;

namespace BackOfficeApi.Data.Repositories.Interfaces
{
    public interface INaturalPersonRepository
    {
        bool getPersonByDocumentOrName(string cpf, string name);
        IEnumerable<NaturalPerson> GetAll();
    }
}
