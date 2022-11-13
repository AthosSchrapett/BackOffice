namespace BackOfficeApi.Model.Entities.Person
{
    public class LegalPerson : Person
    {
        public string Cnpj { get; set; }
        public string TradeName { get; set; }
    }
}
