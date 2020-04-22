using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes {

    delegate double Operação(double x, double y);
    class Delegate_Lambda {

        public static void Executar() {

            Operação som = (a, b) => a + b;
            Operação sub = (a, b) => a - b;
            Operação mut = (a, b) => a * b;
            Operação div = (a, b) => a / b;

            Console.WriteLine("Resultado:");
            Console.WriteLine($"Soma: {som(6, 9)}");
            Console.WriteLine($"Subtração: {sub(50, 9)}");
            Console.WriteLine($"Multiplicação: {mut(95, 3)}");
            Console.WriteLine($"Divisão: {div(80, 5)}");
        }
    }
}
