using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice
{
    public class InvoiceAmount
    {
        public decimal GetInvoiceAmount(ItemDescription itemDescription)
        {
            decimal sum = itemDescription.Quantity * itemDescription.Price;
            return sum;
        }
    }
}
