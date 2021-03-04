﻿using MovieStore.Entities;
using MovieStore.Repository.Interfaces;
using MovieStore.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Services
{
    public class CategoryService:ICategoryService
    {

        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public void Add(Category category)
        {
            _categoryRepository.AddCategory(category);
        }

        public void Delete(int categoryId)
        {
            _categoryRepository.DeleteCategory(categoryId);
        }

        public void Edit(Category category)
        {
            _categoryRepository.EditCategory(category);
        }

        public IEnumerable<Category> GetAllCategories()
        {
            var result = _categoryRepository.GetAllCategories();
            return result;
        }

        public Category GetCategoryById(int id)
        {
            var result = _categoryRepository.GetCategoryById(id);
            return result;
        }
    }
}
