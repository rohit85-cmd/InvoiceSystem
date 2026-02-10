using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvoiceSystem.Data.Entities
{
    public partial class InvoiceItem
    {
        [Key]
        public int ItemId { get; set; }

        public int? InvoiceId { get; set; }

        [StringLength(100)]
        [Unicode(false)]
        public required string Name { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal? Price { get; set; }

        [ForeignKey("InvoiceId")]
        [InverseProperty("InvoiceItems")]
        public virtual Invoice Invoice { get; set; }
    }
}
