using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle {
    class Usuando_Continue {

        public static void Executar() {
            Console.WriteLine("|-----------------------------------------------------------------|");
            Console.WriteLine("|>>>>>>>>>>>>>>| Estrutura de Controle - Usando Continue |<<<<<<<<<<<|");
            Console.WriteLine("|-----------------------------------------------------------------|");
            //-----------------------------------------< Código da Aula >-------------------------------------------//

            int intervalo = 50;

            Console.WriteLine($"Numeros pares entre 1 e {intervalo} !");

            for (int i = 0; i <= intervalo; i++) {
                if (i % 2 == 1) { continue; }
                Console.Write(i + " ");
            }
            Console.WriteLine();
            //Melhor maneira de saber os numeros pares
            
            for (int i = 2; i <= intervalo; i += 2) {  Console.Write(i + " "); }

            Console.WriteLine();

            //------------------------------------------------------------------------------------------------------//

        }//Fim do Executar
    }
}
