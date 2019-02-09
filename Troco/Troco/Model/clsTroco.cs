using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Troco.Model
{


    class ClsTroco
    {
        private decimal VlrPago;
        private decimal VlrTotal;
        public decimal Vlrtroco { get; }

        public ClsTroco(decimal vlrPago, decimal vlrTotal, decimal vlrtroco)
        {
            VlrPago = vlrPago;
            VlrTotal = vlrTotal;
            Vlrtroco = vlrtroco;
        }

       
    }
}
