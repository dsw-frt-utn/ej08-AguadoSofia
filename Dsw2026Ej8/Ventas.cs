using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Sale
    {
        public decimal Amount { get; set; }
        public virtual decimal CalculateTotal() => Amount;
    }

    public class RetailSale : Sale
    {
        public override decimal CalculateTotal() => Amount;
    }
    public class WholesaleSale : Sale
    {
        public override decimal CalculateTotal() => Amount * 0.9m;
    }

}
