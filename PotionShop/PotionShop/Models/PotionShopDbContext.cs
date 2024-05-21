using Microsoft.EntityFrameworkCore;
using PotionShop.Models.Entities;

namespace PotionShop.Models;

public class PotionShopDbContext: DbContext
{
    public PotionShopDbContext(DbContextOptions<PotionShopDbContext> options):base(options){}
    public DbSet<Potion> Potions { get; set; }
   public DbSet<Recipe> Recipes { get; set; }
    public DbSet<Ingredient> Ingredients { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        AddPotions(modelBuilder);
        AddIngredients(modelBuilder);
        AddRecipes(modelBuilder);
    }

    private void AddPotions(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Potion>().HasData(
            new Potion()
            {
                Id = 1,
                Name = "Charmcaster Elixir",
                Type = Enums.PotionType.Elemental,
                PowerLevel = Enums.PotionPowerLevel.Medium,
                Stock = 50,
                WarehouseLocation = Enums.WarehouseLocation.Vault
            }
            );
    }

   private void AddIngredients(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ingredient>().HasData(
                       new Ingredient()
                       {
                           Id = 1,
                           Name = "Hazlenut",
                           Property = Enums.IngredientProperty.Fire,
                           Stock = 50,
                           WarehouseLocation = Enums.WarehouseLocation.Vault
                       }
                                  );
    }
    private void AddRecipes(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Recipe>().HasData(
                       new Recipe()
                       {
                Id = 1,
                Result = "Charmcaster Elixir",
                MainIngredient = "Hazlenut",
                Stock = 50,
                WarehouseLocation = Enums.WarehouseLocation.Vault
            }
                                  );
    }
   
   
}