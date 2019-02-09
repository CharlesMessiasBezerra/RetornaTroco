using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using Troco.Model;
namespace Troco.Controller
{
    class TrocoController
    {
        List<CedulasMoedas> cedulasMoedas = new List<CedulasMoedas>();

        public string  VlrPago { get; set; }
        public string VlrTotal { get; set; }
        private decimal n;
        private string saida;

        public TrocoController()
        {
           
            cedulasMoedas.Add(new CedulasMoedas("Cédula",100));
            cedulasMoedas.Add(new CedulasMoedas("Cédula", 50));
            cedulasMoedas.Add(new CedulasMoedas("Cédula", 10));
            cedulasMoedas.Add(new CedulasMoedas("Cédula", 5));
            cedulasMoedas.Add(new CedulasMoedas("Cédula", 1));            
            cedulasMoedas.Add(new CedulasMoedas("Moeda", ((decimal)0.50)));
            cedulasMoedas.Add(new CedulasMoedas("Moeda", ((decimal)0.10)));
            cedulasMoedas.Add(new CedulasMoedas("Moeda", ((decimal)0.05)));
            cedulasMoedas.Add(new CedulasMoedas("Moeda", ((decimal)0.01)));
            saida = "";

        }

    public string Calcula()
    {
        ClsTroco troco = new ClsTroco(Math.Round(decimal.Parse(VlrTotal), 2),
            Math.Round(decimal.Parse(VlrPago), 2),
            (Math.Round(decimal.Parse(VlrPago), 2)- Math.Round(decimal.Parse(VlrTotal), 2)));


        if ((Math.Round(decimal.Parse(VlrPago), 2) == Math.Round(decimal.Parse(VlrTotal), 2)))
        {
            return "Valor total compra e valor Pago são iguais!";
        }
        return Calc(troco.Vlrtroco, 0);
        }

    // Método recursivo que retorna o troco
    private string Calc(decimal vlrtroco, int i)
    {
        int divisao = 0;
        decimal Resto = 0;
        string strdivisao = "";
        string strtipo = "";
        string strRealCent = "";
        


        if ((!(i <= cedulasMoedas.Count))|| (vlrtroco == 0))
        {
        return saida;        
        }

        if (saida.Equals(""))
        {
            saida = saida + "************************\n";
            saida = saida + "Total Troco : " + vlrtroco + "\n";
            saida = saida + "************************\n";
        }

        if (vlrtroco >= cedulasMoedas[i].Vlr)
        {            
            divisao = (int) (vlrtroco / cedulasMoedas[i].Vlr);
            Resto = (vlrtroco % cedulasMoedas[i].Vlr);
            strdivisao = (divisao).ToString();
            strtipo = (divisao > 1 ? cedulasMoedas[i].Tipo + 's' : cedulasMoedas[i].Tipo);
            strRealCent = (cedulasMoedas[i].Tipo.Equals("Moeda") ? 
                                         (cedulasMoedas[i].Vlr.Equals((decimal)0.01) ? "Centavo": "Centavos") : 
                                          (cedulasMoedas[i].Vlr.Equals(1) ? "Real": "Reais")
                           );
                
                saida = saida + " \n";
                saida = saida + " \n";
                saida = saida + String.Format("{0} {1} de {2:N} {3}", strdivisao, strtipo, cedulasMoedas[i].Vlr, strRealCent );
                saida =  (Calc(Resto, i + 1));
        }
        else
        {
            saida =  Calc((vlrtroco), i + 1);
        }

        return saida;
    }


    //Método faz a validações de entrda 
    public bool Validacao()
    {
        VlrPago = VlrPago.Replace(".", ",");
        VlrTotal = VlrTotal.Replace(".", ",");

            if (!(decimal.TryParse(VlrPago, out n) && decimal.TryParse(VlrTotal, out n)))
            {
                return false;
            }

            if (VlrPago == null && VlrTotal == null)
            {
                return false;
            }                        

            if (decimal.Parse(VlrTotal) > decimal.Parse(VlrPago))
            {
                return false;
            }

            return true;
        }

    }
}
