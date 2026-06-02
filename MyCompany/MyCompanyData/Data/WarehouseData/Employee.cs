using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyCompanyData.Data.WarehouseData
{
    public class Employee
    {
        [Key]
        public int IdEmployee { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [MaxLength(50)]
        public string Position { get; set; }

        [ForeignKey("Warehouse")]
        public int IdWarehouse { get; set; }

        public Warehouse Warehouse { get; set; }
    }
}
