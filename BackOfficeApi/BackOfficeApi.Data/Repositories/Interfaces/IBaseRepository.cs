namespace BackOfficeApi.Data.Repositories.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        IEnumerable<T> GetPagination(int skip, int take);
        int GetCount();
        T GetById(Guid id);
        void Post(T entity);
        void Update(T entity);
        void Delete(Guid id);
    }
}
