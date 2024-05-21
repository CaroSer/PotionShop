using PotionShop.Models.Entities;

namespace PotionShop.Models.Interfaces;

public interface IRecipeService
{
    Task<List<Recipe>> GetAll();
    Task<Recipe> GetById(int id);
    Task<Recipe> Add(Recipe recipe);
    Task Delete(int id);
    Task Update(int id, Recipe updatedRecipe);
}   
