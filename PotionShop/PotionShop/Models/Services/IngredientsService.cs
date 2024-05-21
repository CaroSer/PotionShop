using Microsoft.EntityFrameworkCore;
using PotionShop.Models.Entities;
using PotionShop.Models.Interfaces;

namespace PotionShop.Models.Services
{
    public class IngredientsService : IIngredientService
    {

        private readonly PotionShopDbContext _context;
        public IngredientsService(PotionShopDbContext context) {
            _context = context;
        }

        public async Task<Ingredient> Add(Ingredient ingredient)
        {
            await _context.Ingredients.AddAsync(ingredient);
            await _context.SaveChangesAsync();
            return ingredient;

        }

        public async Task Delete(int id)
        {
            Ingredient ingredient = await _context.Ingredients.FindAsync(id);
            if (ingredient != null)
            {
                _context.Ingredients.Remove(ingredient);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Ingredient>> GetAll()
        {
          return await _context.Ingredients.ToListAsync();
        }

        public async Task<Ingredient> GetById(int id)
        {
            return await _context.Ingredients.FindAsync(id);
        }

        public async Task Update(int id, Ingredient updatedIngredient)
        {
            Ingredient ingredient = await _context.Ingredients.FindAsync(id);
            if (ingredient != null)
            {
                _context.Entry(ingredient).CurrentValues.SetValues(updatedIngredient);
                await _context.SaveChangesAsync();
            }
        }
    }
}
