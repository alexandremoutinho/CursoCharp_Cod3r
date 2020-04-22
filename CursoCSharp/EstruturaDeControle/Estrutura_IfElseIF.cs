using System;

namespace CursoCSharp.EstruturaDeControle {
    class Estrutura_IfElseIF {
        public static void Executar() {

            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine(">>>>>>>>>>>>>>| Estrutura de Controle - IF ELSE IF |<<<<<<<<<<<");
            Console.WriteLine(">>>>>>>>>>>>>>|            Encadesmento e IF       |<<<<<<<<<<<");
            Console.WriteLine("---------------------------------------------------------------");

            Console.Write("Digite a Nota do Aluno: ");
            string entrada = Console.ReadLine();
            Double.TryParse(entrada,out double nota);

            if (nota >= 9.0) {
                Console.WriteLine("Quadro de Honra!");
            } else if (nota >= 7.0) {
                Console.WriteLine("Aprovado");
            } else if (nota >= 5.0) {
                Console.WriteLine("Recuperação");
            } else {
                Console.WriteLine("Te Vejo na Proxima");
            }
            Console.WriteLine("Fim!!!");
            
        }

    }
}
