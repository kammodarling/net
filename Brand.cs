using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Brand
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Brand name is required")]
    [StringLength(50)]
    public string BrandName { get; set; }

    // Navigation property
    public virtual ICollection<Product> Products { get; set; }
}