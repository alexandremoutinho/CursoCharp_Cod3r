using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    public class CalculadoraEstatica {

        public static int Mutiplicar(int a, int b) { return a * b; } // Método de Classe ou Estático
        public  int Somar(int a, int b) { return a + b; } // Método de Instância

    }
    class MetodosEstaticos {

        public static void Executar() {


            var resultado = CalculadoraEstatica.Mutiplicar(2, 3);
            Console.WriteLine(resultado);

            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine(calc.Somar(5,6));

            
        }
    }
}
