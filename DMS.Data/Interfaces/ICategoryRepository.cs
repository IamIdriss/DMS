using DMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.Data.Interfaces
{
    public interface ICategoryRepository
    {
        //PagedResult<Category> GetCategories(string? name, int page);
        Task<Category?> GetCategory(int Id);
        Task<Category> AddCategory(Category upload);
        Task<Category?> UpdateCategory(Category upload);
        Task<Category?> DeleteCategory(int id);
    }
}
