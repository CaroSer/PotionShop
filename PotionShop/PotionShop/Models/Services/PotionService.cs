using Microsoft.EntityFrameworkCore;
using PotionShop.Models;
using PotionShop.Models.Entities;
using PotionShop.Models.Interfaces;

namespace PotionShop.Models.Services
{
    public class PotionService : IPotionService
    {
        private readonly PotionShopDbContext _context;

        public PotionService(PotionShopDbContext context)
        {
            _context = context;
        }

        public async Task<Potion> Add(Potion potion)
        {
            await _context.Potions.AddAsync(potion);
            await _context.SaveChangesAsync();
            return potion;
        }

        public async Task Delete(int id)
        {
            var potion = await _context.Potions.FindAsync(id);
            if (potion != null)
            {
                _context.Potions.Remove(potion);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Potion?> GetById(int id)
        {
            return await _context.Potions.FindAsync(id);
        }

        public async Task<List<Potion>> GetAll()
        {
            return await _context.Potions.ToListAsync();
        }

        public async Task Update(int id, Potion updatedPotion)
        {
            Potion potion = await _context.Potions.FindAsync(id);
            if (potion != null)
            {
                _context.Entry(potion).CurrentValues.SetValues(updatedPotion);
                await _context.SaveChangesAsync();

            }
        }
    }
}