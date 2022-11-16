using BackOfficeApi.Data.Repositories.Interfaces;
using BackOfficeApi.Model.Entities.Person;

namespace BackOfficeApi.Data.Repositories.Implementation
{
    public class LegalPersonRepository : ILegalPersonRepository
    {
        private readonly BackOfficeContext _backOfficeContext;
        public LegalPersonRepository(BackOfficeContext backOfficeContext) => _backOfficeContext = backOfficeContext;

        public bool getPersonByDocumentOrName(string cnpj, string name)
        {
            return _backOfficeContext.Set<LegalPerson>().Any(x => x.Cnpj == cnpj || x.Nome == name);
        }
    }
}
