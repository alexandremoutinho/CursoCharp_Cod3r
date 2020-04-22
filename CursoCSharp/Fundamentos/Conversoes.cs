using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp {
    class Conversoes {

        public static void Executar() {

            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);
            double nota = 9.7;
            int nttruncada = (int) nota;
            Console.WriteLine("Valor Nota {0}",nota);
            Console.WriteLine("Nota Truncada {0}", nttruncada);

            Console.Write("Informe sua Idade: ");
            string idade_str = Console.ReadLine();
            int idade_int = int.Parse(idade_str);
            Console.WriteLine("Idade Inserida: {0}", idade_int);
            idade_int = Convert.ToInt32(idade_str);
            Console.WriteLine($"Resultado Toint32: {idade_int}");

            Console.Write("Digite o 1º Número: ");
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero);
            Console.WriteLine($"Valor do Resultado 1 : {numero}");

            Console.Write("Digite o 2º Número: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine($"Valor do Resultado 2 : {numero2}");


        }
    }
}
