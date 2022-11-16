using BackOfficeApi.Model.Entities.Person;
using BackOfficeApi.Model.Enums;

namespace BackOfficeApi.Service
{
    public interface ILegalPersonService
    {
        IEnumerable<LegalPerson> GetPagination(int skip, int take);
        bool getPersonByDocumentOrName(string cnpj, string name);
        int GetCount();
        LegalPerson GetById(Guid id);
        void Post(LegalPerson legalPerson);
        void Update(LegalPerson legalPerson);
        void Delete(Guid id);
    }
}
