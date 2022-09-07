using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Domain.Entities.Table_Hierarchy
{
    public class InvoiceFile: File
    {
        public decimal Price { get; set; }
    }
}
