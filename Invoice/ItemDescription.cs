using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice
{
    public class ItemDescription
    {
        public string partNumber;
        public string partDescription;
        public int quantity;
        public int price;

        public ItemDescription(string partNumber, string partDescription, int quantity, int price)
        {
            PartNumber = partNumber;
            PartDescription = partDescription;
            Quantity = (quantity >= 0) ? quantity : 0;
            Price = (price >= 0) ? price : 0;
        }

        public string PartNumber { get; set; }
        public string PartDescription { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }
}
