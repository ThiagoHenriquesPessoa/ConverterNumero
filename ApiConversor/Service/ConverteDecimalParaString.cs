namespace ApiConversor.Service
{
    public class ConverteDecimalParaString
    {
        public string NumeroDecimal(string num)
        {
            if (num == "0.00") return "ZERO REAIS";

            string extenso = "";

            string[] Arraynum = num.Split('.');
            string centavos = Arraynum[1];
            string real = Arraynum[0];
            
            if (real != "0")
            {
                real = MilharPorExtenso.Conversor(real);
                var numeroR = real.Split(' ');
                for (int i = 0; i < numeroR.Length; i++)
                {
                    if (numeroR[i].Length > 0)
                    {
                        if (i == 0)
                        {
                            real = numeroR[i];
                        }
                        else
                        {
                            real = real + " E " + numeroR[i];
                        }
                    }
                }
            }


            if (centavos != "00")
            {
                centavos = DezenasPorExtenso.Conversor(centavos);            
                var numeroC = centavos.Split(' ');
                for (int i = 0; i < numeroC.Length; i++)
                {
                    if (numeroC[i].Length > 0)
                    {
                        if (i == 0)
                        {
                            centavos = numeroC[i];
                        }
                        else
                        {
                            centavos = centavos + " E " + numeroC[i];
                        }
                    }
                }
            }

            if (centavos == "00")
            {
                return real = real + " REAIS";
            }
            return extenso = real + " REAIS" + " E " + centavos + " CENTAVOS";
        }
    }
}