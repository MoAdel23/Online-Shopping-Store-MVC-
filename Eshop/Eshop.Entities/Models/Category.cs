using System.ComponentModel.DataAnnotations;

namespace Eshop.Entities.Models;

public class Category
{
    public string Id { get; set; }

    [MaxLength(150)]
    public string Name { get; set; }

    public string Description { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public virtual IEnumerable<Product> Products { get; set; } = new List<Product>();
}
