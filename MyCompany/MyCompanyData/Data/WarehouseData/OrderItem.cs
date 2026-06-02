using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyCompanyData.Data.WarehouseData
{
    public class OrderItem
    {
        [Key]
        public int IdOrderItem { get; set; }

        [ForeignKey("Order")]
        public int IdOrder { get; set; }

        public Order Order { get; set; }

        [ForeignKey("Product")]
        public int IdProduct { get; set; }

        public Product Product { get; set; }

        [Required]
        public int Quantity { get; set; }

        public decimal PurchasePrice { get; set; }
    }
}
