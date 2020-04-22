using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle {
    class Estrutura_Foreach {


        public static void Executar() {
            Console.WriteLine("|------------------------------------------------------------|");
            Console.WriteLine("|>>>>>>>>>>>>>>| Estrutura de Controle - FOREACH |<<<<<<<<<<<|");
            Console.WriteLine("|------------------------------------------------------------|");
            //------------------------------------------------------------------------------------------------------//

            var palavra = "Opá!";

            foreach (var letra in palavra) { Console.WriteLine(letra); }

            var alunos = new string[] { "Alexandre", "Cristiane", "Thaiz Moutinho", "Dulcira", "Gilson" };

            foreach (var aluno in alunos) { Console.WriteLine(aluno);}




        }//Fim do Executar



    }
}
