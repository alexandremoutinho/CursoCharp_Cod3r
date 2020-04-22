using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes {
    class Delegate_ComoParametros {
        public delegate int Operacao(int a, int b);

        public static int Somar(int a, int b) { return a + b; }

        public static string Calculadora(Operacao op, int a, int b) {
            var resultado = op(a, b);
            return $"Resultado: {resultado}";
        }
       public static void Executar() {

            Operacao subtracao = (int x, int y) => x - y;
            Console.WriteLine(Calculadora(subtracao,10,6));
            Console.WriteLine(Calculadora(Somar,10,6));


        }
    }
}
