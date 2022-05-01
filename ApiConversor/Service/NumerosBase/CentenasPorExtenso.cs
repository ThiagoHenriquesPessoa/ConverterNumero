using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiConversor.Service
{
    public class CentenasPorExtenso
    {
        public static string Conversor(string num)
        {
            string unidade = num.Substring(2, 1);
            string dezena = num.Substring(1, 1);
            string centena = num.Substring(0, 1);
            dezena = dezena + unidade;
            if (centena == "0")
            {
                dezena = dezena + unidade;
                return DezenasPorExtenso.Conversor(dezena);
            }
            else if (num == "100")
            {
                return "CEM";
            }
            else
            {
                switch (centena)
                {
                    case "1": return "CENTO " + DezenasPorExtenso.Conversor(dezena); 

                    case "2": return "DUZENTOS " + DezenasPorExtenso.Conversor(dezena);

                    case "3": return "TREZENTOS " + DezenasPorExtenso.Conversor(dezena);

                    case "4": return "QUATROCENTOS " + DezenasPorExtenso.Conversor(dezena);

                    case "5": return "QUINHETOS " + DezenasPorExtenso.Conversor(dezena);

                    case "6": return "SEISCENTOS " + DezenasPorExtenso.Conversor(dezena);

                    case "7": return "SETECENTOS " + DezenasPorExtenso.Conversor(dezena);

                    case "8": return "OITOCENTOS " + DezenasPorExtenso.Conversor(dezena);

                    case "9": return "NOVECENTOS " + DezenasPorExtenso.Conversor(dezena);
                }
            }
            return "";
        }
    }
}

