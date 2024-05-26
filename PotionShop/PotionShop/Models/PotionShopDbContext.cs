using Microsoft.EntityFrameworkCore;
using PotionShop.Components.Layout.Pages;
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
        modelBuilder.Entity<Recipe>()
            .HasOne(r => r.Ingredient)
            .WithMany(i => i.Recipes)
            .HasForeignKey(r => r.IngredientId);

        modelBuilder.Entity<Potion>()
            .HasOne(p => p.Recipe)
            .WithMany(r => r.Potions)
            .HasForeignKey(p => p.RecipeId);

        AddIngredients(modelBuilder);
        AddRecipes(modelBuilder);
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
            },
            new Ingredient()
            {
                Id = 2,
                Name = "Mandrake Root",
                Property = Enums.IngredientProperty.Earth,
                Stock = 30,
                WarehouseLocation = Enums.WarehouseLocation.Sanctum
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
                Stock = 50,
                WarehouseLocation = Enums.WarehouseLocation.Vault,
                IngredientId = 1
            },
              new Recipe()
              {
                  Id = 2,
                  Result = "Love Elixir",
                  Stock = 0,
                  WarehouseLocation = Enums.WarehouseLocation.Sanctum,
                  IngredientId = 1
              }

        );
    }


}