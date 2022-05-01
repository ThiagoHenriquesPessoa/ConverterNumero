using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiConversor.Service
{
    public class PrimeiraDezenasPorExtenso
    {
        public static string Conversor(string num)
        {
            switch (num)
            {
                case "1": return "ONZE ";

                case "2": return "DOZE ";

                case "3": return "TREZE ";

                case "4": return "QUATORZE ";

                case "5": return "QUINZE ";

                case "6": return "DEZESEIS ";

                case "7": return "DEZESETE ";

                case "8": return "DEZOITO ";

                case "9": return "DEZENOVE ";
            }
            return "";
        }
    }
}
