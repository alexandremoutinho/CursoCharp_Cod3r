using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Inferencia {

        public static void Executar() {
            // tipos implicitos 

            var nome = "Leonardo";
            //nome = 123; - Vai dar erro
            Console.WriteLine(nome);

            //int idade;
            var idade = 32;
            Console.WriteLine(idade);


        }
    }
}
