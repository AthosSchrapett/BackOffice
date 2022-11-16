namespace BackOfficeApi.Data.Repositories.Interfaces
{
    public interface ILegalPersonRepository
    {
        bool getPersonByDocumentOrName(string cnpj, string name);
    }
}
