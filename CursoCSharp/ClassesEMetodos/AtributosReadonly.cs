using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    public class Cliente {
        public string Nome;
        readonly DateTime Nascimento;

        public Cliente(string nome, DateTime nascimento) { Nome = nome; Nascimento = nascimento;}
        public string GetDatNasc() {
            return String.Format("{0}/{1}/{2}", Nascimento.Day,Nascimento.Month,Nascimento.Year);
        }
    
    }//Fim da Class Cliente 
    
    class AtributosReadonly {

        public static void Executar() {
            Console.WriteLine("|------------------------------------------------------------|");
            Console.WriteLine("|============<			 Seção 05 			  >=============|");
            Console.WriteLine("|========< Classes & Metodos - Atributos Readonly  >=========|");
            Console.WriteLine("|------------------------------------------------------------|");
            //-----------------------------------------< Código da Aula >---------------------------------//

            var novo_Cli = new Cliente("Alexandre Moutinho", new DateTime(1981, 03, 21));

            Console.WriteLine($"Nome: {novo_Cli.Nome} | Data Nascimento: {novo_Cli.GetDatNasc()} ");

               



        }//Fim do Executar
    }
}
