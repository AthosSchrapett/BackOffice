using BackOfficeApi.Model.Enums;

namespace BackOfficeApi.Model.Entities.Person
{
    public abstract class Person : BaseEntity
    {
        public PersonType Type { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
    }
}
