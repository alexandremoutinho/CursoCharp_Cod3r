using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {


    class DesafioAtributo {

        int a = 10;
        public static void Executar() {
            Console.WriteLine("|------------------------------------------------------------|");
            Console.WriteLine("|============<			 Seção 05 			  >=============|");
            Console.WriteLine("|========< Classes & Metodos - Desafio Atributo   >==========|");
            Console.WriteLine("|------------------------------------------------------------|");
            //-----------------------------------------< Código da Aula >---------------------------------//

            DesafioAtributo vlr = new DesafioAtributo();
        
            Console.WriteLine($"Valor de A = {vlr.a}");




        }//Fim do Executar

    }
}
