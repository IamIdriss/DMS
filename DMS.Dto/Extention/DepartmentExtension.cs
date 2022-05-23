using DMS.Domain.Entities;

namespace DMS.Dto.Extention
{
    public static class DepartmentExtension
    {

        public static DepartmentDto ToDepartmentDto(this Department department)
        {
            return new DepartmentDto()
            {
                Id = department.Id,
                // DepartmentId = agent.DepartmentId,
                Name = department.Name,
                Abbrevation = department.Abbrevation,
                
                //DepartementName = agent.Department?.Name
                City = department.City,
            };
        }
        public static IEnumerable<DepartmentDto> ToDepartmentDtos(this IEnumerable<Department> departments)
        {
            var departmentDtos = new List<DepartmentDto>();
            foreach (var department in departments)
            {
                departmentDtos.Add(department.ToDepartmentDto());
            }
            return departmentDtos;
        }

    }
}
