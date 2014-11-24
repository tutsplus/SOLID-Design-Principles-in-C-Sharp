namespace ISP
{
    public interface IInvoicePrinter {
        void Print( Invoice invoice );
        void PrintComplex( ComplexInvoice complexInvoice );
        
    }
}
