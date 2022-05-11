using DMS.Abstraction;
using DMS.Domain.Entities;

namespace DMS.Services
{
    public class DepartmentService : IDepartmentService
    {
        public Task AddDepartmentAsync(Department department)
        {
            throw new NotImplementedException();
        }

        public Task DeleteDepartmentAsync(int departmentId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Department>> GetAllDepartmentsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Department> GetDepartmentByIdAsync(int departmentId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateDepartmentAsync(Department department)
        {
            throw new NotImplementedException();
        }
    }
}
