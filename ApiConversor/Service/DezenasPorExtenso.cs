namespace ApiConversor.Service
{
    public static class DezenasPorExtenso
    {
        public static string Conversor(string num)
        {
            string unid = num.Substring(1, 1);
            string deze = num.Substring(0, 1);
            if (deze == "0")
            {
                return UnidadePorExtenso.Conversor(unid);
            }
            else if(deze == "1")
            {
                PrimeiraDezenasPorExtenso.Conversor(unid);
            }
            else
            {
                switch (deze)
                {
                    case "2": return "VINTE " + UnidadePorExtenso.Conversor(unid);

                    case "3": return "TRINTA " + UnidadePorExtenso.Conversor(unid);

                    case "4": return "QUARENTA " + UnidadePorExtenso.Conversor(unid);

                    case "5": return "CINQUENTA " + UnidadePorExtenso.Conversor(unid);

                    case "6": return "SESSENTA " + UnidadePorExtenso.Conversor(unid);

                    case "7": return "SETENTA " + UnidadePorExtenso.Conversor(unid);

                    case "8": return "OITENTA " + UnidadePorExtenso.Conversor(unid);

                    case "9": return "NOVENTA " + UnidadePorExtenso.Conversor(unid);
                }
            }
            return "";
        }
    }
}