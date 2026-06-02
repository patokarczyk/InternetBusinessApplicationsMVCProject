using System.ComponentModel.DataAnnotations;

namespace MyCompanyData.Data.WarehouseData
{
    public class Supplier
    {
        [Key]
        public int IdSupplier { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(20)]
        public string Phone { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }
    }
}
