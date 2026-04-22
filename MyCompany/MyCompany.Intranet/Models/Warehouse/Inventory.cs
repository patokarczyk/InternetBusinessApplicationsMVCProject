using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyCompany.Intranet.Models.Warehouse
{
    public class Inventory
    {
        [Key]
        public int IdInventory { get; set; }

        [ForeignKey("Product")]
        public int IdProduct { get; set; }

        public Product Product { get; set; }

        [ForeignKey("Warehouse")]
        public int IdWarehouse { get; set; }

        public Warehouse Warehouse { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}
