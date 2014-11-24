using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public class PrintingSystem {
        private IInvoicePrinter _invoicePrinter;

        public PrintingSystem( IInvoicePrinter invoicePrinter ) {
            _invoicePrinter = invoicePrinter;
        }

        public void Print( Invoice invoice ) {
            _invoicePrinter.Print(invoice);
        }
    }
}
