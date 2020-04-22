using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle {
    class Estrutura_DoWhile {

        public static void Executar() {
            
            Console.WriteLine("|------------------------------------------------------------|");
            Console.WriteLine("|============<			  Seção 04       	   >============|");
            Console.WriteLine("|============< Estrutura de Controle - Do While >============|");
            Console.WriteLine("|------------------------------------------------------------|");

            string entrada;

            do {

                Console.Write("Qual o seu Nome? ");
                entrada = Console.ReadLine();
                Console.WriteLine($"Seja Bem-Vindo {entrada}");
                Console.WriteLine($"Deseja Continuar (S/N)");
                entrada = Console.ReadLine();

            } while (entrada.ToLower() == "s");

        

        }
    }
}
