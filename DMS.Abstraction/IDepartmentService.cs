using DMS.Domain.Entities;

namespace DMS.Abstraction
{
    public interface IDepartmentService
    {
        public Task AddDepartmentAsync(Department department);
        public Task UpdateDepartmentAsync(Department department);
        public Task DeleteDepartmentAsync(int departmentId);
        public Task<IEnumerable<Department>> GetAllDepartmentsAsync();
        public Task<Department> GetDepartmentByIdAsync(int departmentId);
    }
}
