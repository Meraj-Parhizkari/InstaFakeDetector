﻿using InstaFakeDetector.DataLayer.Context;
using InstaFakeDetector.Entities;
using InstaFakeDetector.Services.Contracts;
using Microsoft.EntityFrameworkCore;

namespace InstaFakeDetector.Services;

public class EfCategoryService : ICategoryService
{
    private readonly DbSet<Category> _categories;
    private readonly IUnitOfWork _uow;

    public EfCategoryService(IUnitOfWork uow)
    {
        _uow = uow ?? throw new ArgumentNullException(nameof(uow));

        _categories = _uow.Set<Category>();
    }

    public void AddNewCategory(Category category)
    {
        _uow.Set<Category>().Add(category);
    }

    public IList<Category> GetAllCategories()
    {
        return _categories.ToList();
    }
}