using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public class InvoiceModifier {
        private Invoice _invoice;

        public InvoiceModifier( Invoice invoice ) {
            _invoice = invoice;
        }

        public void SetSubtotal( decimal subtotal ) {
            _invoice.Subtotal = subtotal;
        }

        public void SetTaxRate( decimal taxRate ) {
            _invoice.TaxRate = taxRate;
        }

        public Invoice GenerateInvoice( ) {
            return _invoice;
        }
    }
}
