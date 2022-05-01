using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiConversor.Service
{
    public class MilharPorExtenso
    {
        public static string Conversor(string num)
        {
            string unidade = num.Substring(3, 1);
            string dezena = num.Substring(2, 1);
            string centena = num.Substring(1, 1);
            string milhar = num.Substring(0, 1);
            centena = centena + dezena + unidade;
            if (milhar == "0")
            {
                return CentenasPorExtenso.Conversor(centena);
            }
            else
            {
                return UnidadePorExtenso.Conversor(milhar) + " " + CentenasPorExtenso.Conversor(centena);
            }
        }
    }
}
