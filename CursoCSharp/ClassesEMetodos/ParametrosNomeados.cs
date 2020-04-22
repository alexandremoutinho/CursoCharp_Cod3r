using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class ParametrosNomeados {

        public static void Formatar(int dia,int mes, int ano) {

            Console.WriteLine("{0:D2}/{1:D2}/{2}",dia,mes,ano);

        }

        public static void Executar() {
            Console.WriteLine("|------------------------------------------------------------|");
            Console.WriteLine("|============<			 Seção 05 			  >=============|");
            Console.WriteLine("|========< Classes & Metodos - Parametros Nomeados >=========|");
            Console.WriteLine("|------------------------------------------------------------|");
            //-----------------------------------------< Código da Aula >---------------------------------//

            Formatar(mes:04, dia:15,ano:2020);
            Formatar(15, 04, 2020);


        }//Fim do Executar
    }
}
