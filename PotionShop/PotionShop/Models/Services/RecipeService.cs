using Microsoft.EntityFrameworkCore;
using PotionShop.Models.Entities;
using PotionShop.Models.Interfaces;

namespace PotionShop.Models.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly PotionShopDbContext _context;

        public RecipeService(PotionShopDbContext context)
        {
            _context = context;
        }

        public async Task<Recipe> Add(Recipe recipe)
        {
            await _context.Recipes.AddAsync(recipe);
            await _context.SaveChangesAsync();
            return recipe;
        }

        public async Task Delete(int id)
        {
            _context.Recipes.Remove(await _context.Recipes.FindAsync(id));
            await _context.SaveChangesAsync();
        }

        public async Task<List<Recipe>> GetAll()
        {
            return await _context.Recipes.ToListAsync();
        }

        public async Task<Recipe> GetById(int id)
        {
            return await _context.Recipes.FindAsync(id);
        }

        public async Task Update(int id, Recipe updatedRecipe)
        {
            Recipe recipe = await _context.Recipes.FindAsync(id);
            if (recipe != null)
            {
                _context.Entry(recipe).CurrentValues.SetValues(updatedRecipe);
                await _context.SaveChangesAsync();
            }
        }
    }
}