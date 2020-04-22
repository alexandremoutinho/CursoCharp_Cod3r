using System;

namespace CursoCSharp.Fundamentos {
    class OperadoresUnarios {

        public static void Executar() {

            var vlr_negativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            Console.WriteLine(-vlr_negativo);
            Console.WriteLine(!booleano);
            numero1++;
            Console.WriteLine(numero1);
            --numero1;
            Console.WriteLine(numero1);

            Console.WriteLine(numero1++ == --numero2);
            Console.WriteLine($"Numero 1:  {numero1} e Numero 2:  {numero2}");
            
        }
    }
}
