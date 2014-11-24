namespace LSP
{
    public class InvoiceTotalValidator : Validator
    {
        public override bool Validate( Invoice invoice ) {
            return invoice.CalculateTotal( ) >= 0;
        }
    }
}
