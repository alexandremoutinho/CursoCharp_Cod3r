using System;

namespace CursoCSharp.EstruturaDeControle {
    class Estrutura_If {
        public static void Executar() {
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine(">>>>>>>>>>>>>>|    Estrutura de Controle - IF   |<<<<<<<<<<<");
            Console.WriteLine("------------------------------------------------------------");

            bool bomcomportamento = false;
            string entrada = null;
            Console.Write("Digite a Nota do Aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.Write("Possui bom Comportamento? (S/N): ");
            entrada = Console.ReadLine();

            //if (entrada =="S"|| entrada=="s") {
            //    bomcomportamento = true;
            //}
            //bomcomportamento = (entrada == "S" || entrada == "s");
            bomcomportamento = entrada.ToLower() == "s";

            if (nota>=9.0 && bomcomportamento) {
                Console.WriteLine("Quadro de Honra!!");
            }
            if (nota>=9.0 && !bomcomportamento) {
                Console.WriteLine("Quadro da Deshonra!!");
            }


        }
    }
}
