using System;


namespace CursoCSharp.ClassesEMetodos {
    class ParametroPadrao {
        public static int Somar(int a = 1, int b= 1) {
            return a + b;
        }
        public static void Executar() {

            Console.WriteLine(Somar(10,23));
            Console.WriteLine(Somar(50));
            Console.WriteLine(Somar());

            Console.WriteLine($"Informe os Valores:{Somar(a:int.Parse(Console.ReadLine()), b: int.Parse(Console.ReadLine()))}");

        }
    }
}
