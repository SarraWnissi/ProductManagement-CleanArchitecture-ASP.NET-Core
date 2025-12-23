using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Product
{
    public int Id { get; set; }
    [Required, StringLength(100, MinimumLength = 2)]
    public string Name { get; set; } = null!;
    [StringLength(5000)]
    public string? Description { get; set; }
    [Column(TypeName = "decimal(18,2)")]
    public decimal Price { get; set; }
    [Range(0, int.MaxValue, ErrorMessage = "Stock cannot be negative.")]
    public int Stock { get; set; }

    // Business rule: Ensure Price is positive and Stock is not negative
    public void ValidateBusinessRules()
    {
        if (Price <= 0)
            throw new InvalidOperationException("Product price must be positive.");
        if (Stock < 0)
            throw new InvalidOperationException("Product stock cannot be negative.");
    }
}
