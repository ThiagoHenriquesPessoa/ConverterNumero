namespace ApiConversor.Service
{
    public class CalculoDeCentena
    {
        public static string Conversor(string real)
        {
            real = CentenasPorExtenso.Conversor(real);
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
            return real;
        }
    }
}