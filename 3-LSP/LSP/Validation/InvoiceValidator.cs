using System.Collections.Generic;
using System.Linq;

namespace LSP
{
    public class InvoiceValidator {
        private List<Validator> _validators;

        public InvoiceValidator( List<Validator> validators  ) {
            _validators = validators;
        }

        public bool Validate(Invoice invoice) {
            return _validators.All( v => v.Validate( invoice ) );
        }
    }
}
