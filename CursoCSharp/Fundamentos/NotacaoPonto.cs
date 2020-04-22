using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class NotacaoPonto {
        public static void Executar() {

            var saudacao = "Olá ".ToUpper().Insert(4, "World!").Replace("World!", "Mundo!");
            
            Console.WriteLine(saudacao);
            Console.WriteLine("Teste".Length);// Length ele retorna o tamanho da string

            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length); // "?" -  não permitira que apresente erro pois o valor esta nulo. 


        }
    }
}
