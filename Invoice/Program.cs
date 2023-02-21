namespace Invoice
{
    class Program
    {
        static void Main(string[] args)
        {
            ItemDescription[] itemDescriptions = new ItemDescription[11];
            itemDescriptions[0] = new ItemDescription("00", "PhotographyItem", 4, 17.50M);
            itemDescriptions[1] = new ItemDescription("01", "WakeboardItem", 2, 10);
            itemDescriptions[2] = new ItemDescription("02", "DrumSetItem", 7, 170);
            itemDescriptions[3] = new ItemDescription("03", "PaintingItem", 8, 100);
            itemDescriptions[4] = new ItemDescription("04", "PhotographyItem", 20, 12);
            itemDescriptions[5] = new ItemDescription("05", "WakeboardItem", 17, 14);
            itemDescriptions[6] = new ItemDescription("06", "DrumSetItem", 24, 27.22M);
            itemDescriptions[7] = new ItemDescription("07", "PaintingItem", 27, 49.34M);
            itemDescriptions[8] = new ItemDescription("08", "LongboardItem", 11, 50);
            itemDescriptions[9] = new ItemDescription("09", "SwimmingItem", 40, 2);
            itemDescriptions[10] = new ItemDescription("010", "PetItem", 47, 33.57M);

            InvoiceAmount invoiceAmount = new InvoiceAmount();

            List<decimal> listOfAmounts = new List<decimal>();

            Console.WriteLine("Invoice details");
            foreach (var item in itemDescriptions)
            {
                Console.WriteLine("- {0}, {1}, {2}, {3}",
                    item.PartNumber, item.PartDescription, item.Quantity, item.Price);

                decimal sum = invoiceAmount.GetInvoiceAmount(item);
                listOfAmounts.Add(sum);
            }

            decimal totalAmount = listOfAmounts.Sum(sum => sum);
            Console.WriteLine($"You bought: {itemDescriptions.Length} items for total sum of: {totalAmount} EUR");
        }
    }
}