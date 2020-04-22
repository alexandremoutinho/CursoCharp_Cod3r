using System;

namespace CursoCSharp.EstruturaDeControle {
    class Estrutura_While {

        public static void Executar() {

            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine(">>>>>>>>>>>>>>|  Estrutura de Controle - While  |<<<<<<<<<<<");
            Console.WriteLine("------------------------------------------------------------");

            int palpite = 0;
            Random random = new Random();

            int numeroSecreto = random.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;
            string entrada;
            
            while(tentativasRestantes>0 && !numeroEncontrado) {

                Console.Write($"Insira o Seu Palpite: ");
                entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);
                tentativas++;
                tentativasRestantes--;
                if (numeroSecreto == palpite) {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Número Encontrado em {tentativas} Tentativas!");
                    Console.BackgroundColor = corAnterior;
                } else if (palpite > numeroSecreto) { 
                    Console.WriteLine("Menor... Tente Novamente!");
                    Console.WriteLine($"Tentativas Restantes...{tentativasRestantes}");
                } else {
                    Console.WriteLine("Maior... Tente Novamente!");
                    Console.WriteLine($"Tentativas Restantes...{tentativasRestantes}");
                }

            }

        }


    }
}
