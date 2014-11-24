using System;

namespace ISP
{
    public class InvoicePrinter : IInvoicePrinter, ISomeOtherPrint
    {
        public void Print(Invoice invoice)
        {
            // Logic goes here.
        }

        public void PrintComplex( ComplexInvoice complexInvoice ) 
        {
            // Logic goes here.
        }

        public void SomeOtherPrint( Invoice invoice ) {
            // Logic goes here.
        }
    }
}
