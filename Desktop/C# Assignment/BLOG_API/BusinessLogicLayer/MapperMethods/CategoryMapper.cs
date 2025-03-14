using DomainLayer.DTO;
using DomainLayer.DTO.CategoryDTO;
using DomainLayer.Models;
using DomainLayer.Models.TemsBlogModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.MapperMethods
{
    public class CategoryMapper
    {
        public DomainLayer.Models.TemsBlogModels.Category MapCategoryDtoToCategory(CategoryZDto CategoryZDto)
        {
            return new DomainLayer.Models.TemsBlogModels.Category
            {
                Name = CategoryZDto.Name,
            };
        }

        public CategoryZDto MapCategoryToCategoryZDto(DomainLayer.Models.TemsBlogModels.Category category)
        {
            return new CategoryZDto
            {
                Name = category.Name,
            };
        }

        public DomainLayer.Models.TemsBlogModels.Category MapDeleteCategoryZRequestToCategoryZ(DeleteRequestCategoryZDto deleteRtCategoryDto)
        {
            return new DomainLayer.Models.TemsBlogModels.Category
            {
                Id = deleteRtCategoryDto.Id
            };
        }
    }
}
