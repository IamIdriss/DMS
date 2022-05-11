using DMS.Domain.Entities;

namespace DMS.Abstraction
{
    public interface ICategoryService
    {
        public Task AddCategoryAsync(Category category);
        public Task UpdateCategoryAsync(Category category);
        public Task DeleteCategoryAsync(int categoryId);
        public Task<IEnumerable<Category>> GetAllCategorysAsync();
        public Task<Category> GetCategoryByIdAsync(int categoryId);
    }
}
