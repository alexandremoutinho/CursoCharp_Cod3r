using System;
using System.Globalization;

namespace CursoCSharp {
    class FormatandoNumero {
        public static void Executar() {
            double valor = 15.175;
            Console.WriteLine($"Valor: {valor.ToString("F2")}");
            Console.WriteLine($"Valor: {valor.ToString("C")}");
            Console.WriteLine($"Valor: {valor.ToString("P")}");
            Console.WriteLine($"Valor: {valor.ToString("#.##")}");

            CultureInfo cultura = new CultureInfo("en-US");
            Console.WriteLine($"Valor: {valor.ToString("C2",cultura)}");

            int inteiro = 256;
            Console.WriteLine($"Inteiro: {inteiro.ToString("D10")}");


        }
    }
}
