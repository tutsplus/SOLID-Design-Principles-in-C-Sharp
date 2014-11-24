namespace OCP
{
    public class Invoice
    {
        public decimal Subtotal { get; set; }
        public decimal TaxRate { get; set; }

        public decimal CalculateTax()
        {
            return Subtotal * TaxRate / 100;
        }

        public decimal CalculateTotal()
        {
            return Subtotal + CalculateTax();
        }

    }
}
