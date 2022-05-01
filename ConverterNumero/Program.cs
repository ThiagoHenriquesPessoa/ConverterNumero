using ApiConversor.Service;
using System;

namespace ConverterNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            ConverteDecimalParaString converteDecimal = new ConverteDecimalParaString();
            string num = Console.ReadLine();
            Decimal numero = Convert.ToDecimal(num);
            Console.WriteLine(converteDecimal.NumeroDecimal(numero));
        }
    }
}
