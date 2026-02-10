using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceSystem.Business.Dto
{
    public class InvoiceItemsDto
    {
        public int ItemID { get; set; }
        public int InvoiceID { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }
    }
}
