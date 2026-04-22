using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyCompany.Intranet.Models.Warehouse
{
    public class Order
    {
        [Key]
        public int IdOrder { get; set; }

        [ForeignKey("Supplier")]
        public int IdSupplier { get; set; }

        public Supplier Supplier { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [MaxLength(50)]
        public string Status { get; set; }
    }
}
