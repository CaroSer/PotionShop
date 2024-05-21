using PotionShop.Models.Entities;

namespace PotionShop.Models.Interfaces;

public interface IIngredientService
{
    Task<List<Ingredient>> GetAll();
    Task<Ingredient> GetById(int id);
    Task<Ingredient> Add(Ingredient ingredient);
    Task Delete(int id);
    Task Update(int id, Ingredient updatedIngredient);
}   
