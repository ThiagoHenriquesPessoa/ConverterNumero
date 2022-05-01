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
            Console.WriteLine(converteDecimal.NumeroDecimal(num));
        }
    }
}
