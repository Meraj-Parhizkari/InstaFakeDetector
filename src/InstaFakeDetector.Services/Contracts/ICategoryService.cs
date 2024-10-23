using InstaFakeDetector.Entities;

namespace InstaFakeDetector.Services.Contracts;

public interface ICategoryService
{
    void AddNewCategory(Category category);
    IList<Category> GetAllCategories();
}