using DMS.Domain.Entities;

namespace DMS.Dto.Extention
{
    public static class CategoryExtension
    {

        public static CategoryDto ToCategoryDto(this Category category)
        {
            return new CategoryDto()
            {
                Id = category.Id,
                Name = category.Name,
                
                
                
                
            };
        }
        public static IEnumerable<CategoryDto> ToCategoryDtos(this IEnumerable<Category> categorys)
        {
            var categoryDtos = new List<CategoryDto>();
            foreach (var category in categorys)
            {
                categoryDtos.Add(category.ToCategoryDto());
            }
            return categoryDtos;
        }

    }
}
