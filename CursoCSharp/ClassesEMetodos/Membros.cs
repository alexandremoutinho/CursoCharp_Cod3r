using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class Membros {
         public static void Executar() {
            Console.WriteLine("|------------------------------------------------------------|");
            Console.WriteLine("|============<			 Seção 05 			  >=============|");
            Console.WriteLine("|============< Membros - Atributos e Métodos   >=============|");
            Console.WriteLine("|------------------------------------------------------------|");
            //-----------------------------------------< Código da Aula >---------------------------------//

            Pessoa sicrano = new Pessoa();

            sicrano.Nome = "Alexandre Moutinho";
            sicrano.Idade = 39;

            //Console.WriteLine($"{sicrano.Nome} Tem a Idade de {sicrano.Idade} anos.");
            sicrano.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Cristiane Moutinho";
            fulano.Idade = 34;
            var apresentacaoDeFulano = fulano.Apresentar();

            Console.WriteLine(apresentacaoDeFulano);


        }//Fim do Executar


    }
}
