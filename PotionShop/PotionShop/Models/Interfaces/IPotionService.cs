using PotionShop.Models.Entities;

namespace PotionShop.Models.Interfaces;

public interface IPotionService
{

    Task<List<Potion>> GetAll();
    Task<Potion> GetById(int id);
    Task<Potion> Add(Potion potion);
    Task Delete(int id);
    Task Update(int id, Potion updatedPotion);
}