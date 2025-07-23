using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Product
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Product name is required")]
    [StringLength(100)]
    public string Name { get; set; }

    [Required(ErrorMessage = "Rate is required")]
    [Range(1, 100000, ErrorMessage = "Rate must be positive")]
    public decimal Rate { get; set; }

    [Display(Name = "Brand")]
    [Required(ErrorMessage = "Brand selection is required")]
    public int BrandId { get; set; }

    // Navigation property
    [ForeignKey("BrandId")]
    public virtual Brand Brand { get; set; }
}