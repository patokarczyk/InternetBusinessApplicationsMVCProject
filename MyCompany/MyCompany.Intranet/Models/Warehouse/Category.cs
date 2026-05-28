using System.ComponentModel.DataAnnotations;

namespace MyCompany.Intranet.Models.Warehouse
{
    public class Category
    {
        [Key]
        public int IdCategory { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(200)]
        public string Description { get; set; }
    }
}
