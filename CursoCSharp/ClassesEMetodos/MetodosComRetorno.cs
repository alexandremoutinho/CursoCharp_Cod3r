using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    
    
    class CalculadoraComum {
        public int Somar(int a, int b) { return a + b; }
        public int Subtrair(int a, int b) { return a - b; }
        public int Multiplicar (int a, int b) { return a * b; }
        public int Dividir (int a, int b) { return a / b; }
          
    }
    
    class CalculadoraCadeia{

        int memoria;
        public CalculadoraCadeia Somar(int a ) { memoria += a; return this; }
        public CalculadoraCadeia Subitrair(int a ) { memoria -= a; return this; }
        public CalculadoraCadeia Mutiplicar(int a ) { memoria *= a; return this; }
        public CalculadoraCadeia Limpar() { memoria = 0; return this; }
        public CalculadoraCadeia Print() { Console.WriteLine($"Resultado Calculo:  {memoria}"); ; return this; }
        public int Resultado() {return memoria; }
    }
    class MetodosComRetorno {
        public static void Executar() {
            Console.WriteLine("|------------------------------------------------------------|");
            Console.WriteLine("|============<			 Seção 05 			  >=============|");
            Console.WriteLine("|============<       Metodos Com Retorno       >=============|");
            Console.WriteLine("|------------------------------------------------------------|");
            //-----------------------------------------< Código da Aula >---------------------------------//

            var calculadoraComum = new CalculadoraComum();
            var resultado = calculadoraComum.Somar(2, 9);
            Console.WriteLine($"Resultado da Soma:          {resultado}");
            Console.WriteLine($"Resultado da Subtração:     {calculadoraComum.Subtrair(resultado,3)}");
            Console.WriteLine($"Resultado da Multiplicação: {calculadoraComum.Multiplicar(resultado,3)}");
            Console.WriteLine($"Resultado da Divisão:       {calculadoraComum.Dividir(resultado,3)}");

            var calc_Cadeia = new CalculadoraCadeia();
            calc_Cadeia.Somar(5).Mutiplicar(6).Subitrair(4).Print().Limpar().Print();
            resultado = calc_Cadeia.Somar(12).Subitrair(5).Mutiplicar(15).Resultado();
            Console.WriteLine($"Novo Resultado é {resultado}");
                      
        }//Fim do Executar

    }
}
