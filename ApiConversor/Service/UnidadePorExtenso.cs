namespace ApiConversor.Service
{
    public class UnidadePorExtenso
    {
        public static string Conversor(string num)
        {
            switch (num)
            {
                case "1": return "UM ";

                case "2": return "DOIS ";

                case "3": return "TRÊS ";

                case "4": return "QUATRO ";

                case "5": return "CINCO ";

                case "6": return "SEIS ";

                case "7": return "SETE ";

                case "8": return "OITO ";

                case "9": return "NOVE ";
            }
            return "";
        }
    }
}