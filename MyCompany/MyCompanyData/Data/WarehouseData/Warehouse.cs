using System.ComponentModel.DataAnnotations;

namespace MyCompanyData.Data.WarehouseData
{
    public class Warehouse
    {
        [Key]
        public int IdWarehouse { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(150)]
        public string Location { get; set; }
    }
}
