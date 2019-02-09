using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Troco.Model
{
    class CedulasMoedas
    {
        public string Tipo { get; }
        public decimal Vlr { get; }

        public CedulasMoedas(string tipo, decimal vlr)
        {
            Tipo = tipo;
            Vlr = vlr;
        }        
        
    }
}
