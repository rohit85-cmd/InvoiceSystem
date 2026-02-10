using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceSystem.Data.Entities
{
    public partial class Invoice
    {
        [Key]
        public int InvoiceId { get; set; }

        [StringLength(100)]
        [Unicode(false)]
        public required string CustomerName { get; set; }

        [InverseProperty("Invoice")]
        public virtual ICollection<InvoiceItem> InvoiceItems { get; set; } = new List<InvoiceItem>();
    }
}
