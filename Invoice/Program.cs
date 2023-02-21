namespace Invoice
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice[] invoice = new Invoice[11];
            invoice[0] = new Invoice("00", "Photography item", 4, 17.50M);
            invoice[1] = new Invoice("01", "Wakeboard item", 2, 10);
            invoice[2] = new Invoice("02", "DrumSet item", 7, 170);
            invoice[3] = new Invoice("03", "Painting item", 8, 100);
            invoice[4] = new Invoice("04", "Photography item", 20, 12);
            invoice[5] = new Invoice("05", "Wakeboard item", 17, 14);
            invoice[6] = new Invoice("06", "DrumSet item", 24, 27.22M);
            invoice[7] = new Invoice("07", "Painting item", 27, 49.34M);
            invoice[8] = new Invoice("08", "Longboard item", 11, 50);
            invoice[9] = new Invoice("09", "Swimming item", 40, 2);
            invoice[10] = new Invoice("010", "Pet item", 47, 33.57M);

            InvoiceAmount invoiceAmount = new InvoiceAmount();

            List<decimal> listOfAmounts = new List<decimal>();

            Console.WriteLine("Individual invoice details: ");
            foreach (var item in invoice)
            {
                Console.WriteLine("- {0}, {1}, {2}, {3}",
                    item.PartNumber, item.PartDescription, item.Quantity, item.Price);

                decimal sum = invoiceAmount.getInvoiceAmount(item);
                listOfAmounts.Add(sum);

                decimal totalAmountPerOneInvoice = listOfAmounts.Sum(sum => sum);
                Console.WriteLine($"You bought: {item.Quantity} {item.PartDescription} for total sum of: {sum} EUR");
            }

            decimal totalAmount = listOfAmounts.Sum(sum => sum);
            Console.WriteLine($"Total sum for all invoices {totalAmount} EUR");
        }
    }
}