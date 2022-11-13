using BackOfficeApi.Model.Entities;

namespace BackOfficeApi.Model.Entities.Person
{
    public class NaturalPerson : Person
    {
        public string Cpf { get; set; }
        public string Nickname { get; set; }

        public virtual ICollection<Department> Departments { get; set; }
    }
}
