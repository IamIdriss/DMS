using DMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.Data.Interfaces
{
    public interface IDepartmentRepository
    {
        //PagedResult<Department> GetDepartments(string? name, int page);
        Task<Department?> GetDepartment(int Id);
        Task<Department> AddDepartment(Department department);
        Task<Department?> UpdateDepartment(Department department);
        Task<Department?> DeleteDepartment(int Id);
    }
}
