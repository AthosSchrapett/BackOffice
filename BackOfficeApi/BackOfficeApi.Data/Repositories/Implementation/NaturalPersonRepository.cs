using BackOfficeApi.Data.Repositories.Interfaces;
using BackOfficeApi.Model.Entities.Person;
using Microsoft.EntityFrameworkCore;

namespace BackOfficeApi.Data.Repositories.Implementation
{
    public class NaturalPersonRepository : INaturalPersonRepository
    {
        private readonly BackOfficeContext _backOfficeContext;
        public NaturalPersonRepository(BackOfficeContext backOfficeContext) => _backOfficeContext = backOfficeContext;

        public IEnumerable<NaturalPerson> GetAll()
        {
            return _backOfficeContext.Set<NaturalPerson>();
        }

        public bool getPersonByDocumentOrName(string cpf, string name)
        {
            return _backOfficeContext.Set<NaturalPerson>().Any(x => x.Cpf == cpf || x.Nome == name);
        }
    }
}
