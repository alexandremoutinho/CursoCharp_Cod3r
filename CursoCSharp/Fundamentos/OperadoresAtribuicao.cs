using System;
using System.Dynamic;
using System.Linq.Expressions;

namespace CursoCSharp.Fundamentos {
    class OperadoresAtribuicao {
        public static void Executar() {

            var num1 = 3;
            Console.WriteLine($"Valor Inicial {num1}");
            num1 += 10;
            Console.WriteLine($"Resultado de +=  {num1}");
            num1 -= 3;
            Console.WriteLine($"Resultado de -=  {num1}");
            num1 /= 2;
            Console.WriteLine($"Resultado de /=  {num1}");
            num1 *= 12;
            Console.WriteLine($"Resultado de *=  {num1}");

            int a = 1;
            Console.WriteLine($"Valor de A {a}");
            int b = a;
            Console.WriteLine($"Valor de B {b}");
            a++;
            b--;
            Console.WriteLine($"Valor de A {a} e de B {b}");
            
            // Código abaixo será comprendido mais para frente

            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "João";

            dynamic d = c;
            d.nome = "Maria";

            Console.WriteLine(c.nome); //Atribuição por Referencia 

        }
    }
}
