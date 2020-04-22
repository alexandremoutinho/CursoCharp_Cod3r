using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle {
    class Estrutura_IfElse {

        public static void Executar() {

            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine(">>>>>>>>>>>>>>| Estrutura de Controle - IF ELSE |<<<<<<<<<<<");
            Console.WriteLine("------------------------------------------------------------");

            double nota = 6.0;

            if (nota >= 7.0) {
                Console.WriteLine("Aprovado!");
                Console.WriteLine("Não Fez mais que sua obrigação...");
            } else {
                Console.WriteLine("Recuperação!");
            }

        }

    }

}
