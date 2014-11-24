namespace ISP
{
    public class ComplexInvoiceModifier
    {
        private ComplexInvoice _complexInvoice;

        public ComplexInvoiceModifier( ComplexInvoice invoice ) {
            _complexInvoice = invoice;
        }

        public void SetSubtotal( decimal subtotal ) {
            _complexInvoice.Subtotal = subtotal;
        }

        public void SetTaxRate( decimal taxRate ) {
            _complexInvoice.TaxRate = taxRate;
        }

        public void SetSecondTaxRate(decimal taxRate)
        {
            _complexInvoice.SecondTaxRate = taxRate;
        }

        public ComplexInvoice GenerateInvoice( ) {
            return _complexInvoice;
        }
    }
}
