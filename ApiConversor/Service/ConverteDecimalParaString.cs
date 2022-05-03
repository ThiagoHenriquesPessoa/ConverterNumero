namespace ApiConversor.Service
{
    public class ConverteDecimalParaString
    {
        public string NumeroDecimal(decimal num)
        {
            if (num == 0) return "ZERO REAIS";
            if(num == 1) return "UM REAL";
            string numero = num.ToString("000000000000000.00");
            string centena = "";
            string milhar = "";
            string milhao = "";
            string bilhao = "";
            string trilhao = "";

            string[] Arraynum = numero.Split(',');
            string centavos = Arraynum[1];
            string real = Arraynum[0];
            if (real.Length > 0)
            {
                centena = real.Substring(12, 3);
                milhar = real.Substring(9, 3);
                milhao = real.Substring(6, 3);
                bilhao = real.Substring(3, 3);
                trilhao = real.Substring(0, 3);
                if (centena != "000") centena = CalculoDeCentena.Conversor(centena);
                else centena = "";
                if (milhar != "000") milhar = CalculoDeCentena.Conversor(milhar) + " MIL E";
                else milhar = "";
                if (milhao != "000") milhao = CalculoDeCentena.Conversor(milhao) + " MILHÔES E";
                else milhao = "";
                if (bilhao != "000") bilhao = CalculoDeCentena.Conversor(bilhao) + " BILHÔES E";
                else bilhao = "";
                if (trilhao != "000") trilhao = CalculoDeCentena.Conversor(trilhao) + " TRILHÔES E";
                else trilhao = "";
            }

            if (centavos != "00")
            {
                if (centavos == "01") centavos = "UM CENTAVO";
                else
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
                    centavos = centavos + " CENTAVOS";
                }
            }
            if(num > 999999999999) real = trilhao + bilhao + milhao + milhar + centena;
            else if(num > 999999999) real = trilhao + bilhao + milhao + milhar + centena;
            else if(num > 999999) real = milhao + milhar  + centena;
            else if(num > 999) real = milhar + centena;
            else if(num > 0) real = centena;

            if (real == "UM") real = real + " REAL";
            else real = real + " REAIS";

            if (centavos != "00")
            {
                return real + " E " + centavos;
            }
            return real;
        }
    }
}