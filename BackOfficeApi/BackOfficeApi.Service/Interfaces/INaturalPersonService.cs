using BackOfficeApi.Model.Entities.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOfficeApi.Service
{
    public interface INaturalPersonService
    {
        IEnumerable<NaturalPerson> GetPagination(int skip, int take);
        IEnumerable<NaturalPerson> GetAll();
        bool getPersonByDocumentOrName(string cpf, string name);
        int GetCount();
        NaturalPerson GetById(Guid id);
        void Post(NaturalPerson naturalPerson);
        void Update(NaturalPerson naturalPerson);
        void Delete(Guid id);
    }
}
