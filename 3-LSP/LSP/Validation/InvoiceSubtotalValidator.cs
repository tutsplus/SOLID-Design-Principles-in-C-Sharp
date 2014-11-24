namespace LSP
{
    public class InvoiceSubtotalValidator : Validator
    {
        public override bool Validate( Invoice invoice ) {
            return invoice.Subtotal >= 0;
        }
    }
}
