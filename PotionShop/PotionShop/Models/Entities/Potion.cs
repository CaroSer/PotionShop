using PotionShop.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace PotionShop.Models.Entities;

public class Potion
{
    [Key] public int Id { get; set; }
    [Required] public PotionType Type { get; set; }
    [Required] public PotionPowerLevel PowerLevel { get; set; }
    [Required][Range(0, 999)] public int Stock { get; set; }
    [Required] public WarehouseLocation WarehouseLocation { get; set; }
    public int RecipeId { get; set; }
    virtual public Recipe? Recipe { get; set; }
}