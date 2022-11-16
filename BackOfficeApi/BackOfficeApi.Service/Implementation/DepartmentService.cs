using BackOfficeApi.Data.Infra;
using BackOfficeApi.Model.Entities;

namespace BackOfficeApi.Service
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IUnityOfWork _unityOfWork;

        public DepartmentService(IUnityOfWork unityOfWork) => _unityOfWork = unityOfWork;

        public void Post(Department department)
        {
            _unityOfWork.DepartmentRepository.Post(department);
            _unityOfWork.Commit();
        }

        public Department GetById(Guid id)
        {
            return _unityOfWork.DepartmentRepository.GetById(id);
        }

        public int GetCount()
        {
            return _unityOfWork.DepartmentRepository.GetCount();
        }

        public IEnumerable<Department> GetPagination(int skip, int take)
        {
            return _unityOfWork.DepartmentRepository.GetPagination(skip, take);
        }

        public void Update(Department department)
        {
            _unityOfWork.DepartmentRepository.Update(department);
            _unityOfWork.Commit();
        }

        public void Delete(Guid id)
        {
            _unityOfWork.DepartmentRepository.Delete(id);
            _unityOfWork.Commit();
        }
    }
}
