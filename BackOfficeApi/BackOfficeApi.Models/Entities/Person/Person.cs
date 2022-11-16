using BackOfficeApi.Model.Enums;

namespace BackOfficeApi.Model.Entities.Person
{
    public abstract class Person : BaseEntity
    {
        public PersonType Type { get; set; }
        public string Nome { get; set; }
        public string Cep { get; set; }
        public string Address { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public Qualification Qualification { get; set; }
    }
}
