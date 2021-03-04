using MovieStore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Repository.Interfaces
{
    public interface ICategoryRepository
    {
        void AddCategory(Category category);

        void EditCategory(Category category);

        void DeleteCategory(int categoryId);

        Category GetCategoryById(int id);

        IEnumerable<Category> GetAllCategories();
    }
}
