using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice
{
    public class InvoiceAmount
    {
        public decimal getInvoiceAmount(Invoice invoice)
        {
            decimal sum = invoice.Quantity * invoice.Price;
            return sum;
        }
    }
}
