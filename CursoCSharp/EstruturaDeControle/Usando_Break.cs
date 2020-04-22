using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle {
    class Usuando_Break {

        public static void Executar() {
            Console.WriteLine("|-----------------------------------------------------------------|");
            Console.WriteLine("|>>>>>>>>>>>>>>| Estrutura de Controle - Usando Break |<<<<<<<<<<<|");
            Console.WriteLine("|-----------------------------------------------------------------|");
            //------------------------------------------------------------------------------------------------------//

            Random random = new Random();

            int numero = random.Next(1, 51);

            Console.WriteLine($"O Numero que Queremos é --> {numero}");

            for (int i = 0; i <= numero; i++) {
                Console.Write("{0} é o Número que Queremos?",i);
                if (i == numero) {Console.WriteLine("Sim!"); break; } else { Console.WriteLine("Não!"); }
            }
            Console.WriteLine("Fim!");


            //------------------------------------------------------------------------------------------------------//

           
        }//Fim do Executar
    }
}
