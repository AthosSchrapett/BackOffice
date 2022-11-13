using BackOfficeApi.Model.Entities.Person;
using Microsoft.EntityFrameworkCore;

namespace BackOfficeApi.Data.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly BackOfficeContext _backOfficeContext;

        public BaseRepository(BackOfficeContext backOfficeContext) => _backOfficeContext = backOfficeContext;

        public void Post(T entity) => _backOfficeContext.Set<T>().Add(entity);
        public IEnumerable<T> GetPagination(int skip, int take) => _backOfficeContext.Set<T>().Skip(skip).Take(take);
        public int GetCount() => _backOfficeContext.Set<T>().Count();
        public T GetById(Guid id) => _backOfficeContext.Set<T>().Find(id);        
        public void Update(T entity) => _backOfficeContext.Entry(entity).State = EntityState.Modified;
        public void Delete(Guid id) => _backOfficeContext.Remove(GetById(id));
    }
}
