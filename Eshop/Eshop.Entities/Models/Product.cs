

using System.ComponentModel.DataAnnotations;

namespace Eshop.Entities.Models;

public class Product
{

    public string Id { get; set; }

    [MaxLength(150)]
    public string Name { get; set; }

    public string Description { get; set; }

    public string Image { get; set; }

    public decimal Price { get; set; }

    public string CategoryId { get; set; }

    public virtual Category Category { get; set; }
}
