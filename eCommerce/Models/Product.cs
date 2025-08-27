using System.ComponentModel.DataAnnotations;

namespace eCommerce.Models;

/// <summary>
/// Represents an idividual product for sale
/// </summary>

public class Product
{
    [Key]
    /// <summary>
    /// The unique identifier for the product
    /// </summary>


    public int ProductId { get; set; }

    /// <summary>
    /// The user facing title of the product
    /// </summary>

    [StringLength(50, ErrorMessage = "Title cannot be more than 50 characters")]

    public required string Title { get; set; }

    /// <summary>
    /// The current sales price of the product
    /// </summary>

    [Range(0, 10_000)]

    public double Price { get; set; }
}

