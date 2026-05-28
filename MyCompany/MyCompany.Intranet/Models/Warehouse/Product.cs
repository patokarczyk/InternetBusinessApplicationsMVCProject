using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MyCompany.Intranet.Models.Warehouse
{
    public class Product
    {
        [Key]
        public int IdProduct { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        [ForeignKey("Category")]
        public int IdCategory { get; set; }

        public Category Category { get; set; }
    }
}
