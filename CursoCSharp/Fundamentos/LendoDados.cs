using System;
using System.Globalization;

namespace CursoCSharp {
    class LendoDados {

        public static void Executar() {

            Console.Write("Qual é o Seu nome? ");
            string nome = Console.ReadLine();
            
            Console.Write("Qual sua Idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Qual o Seu Salario? ");
            double salario = double.Parse(Console.ReadLine());

            Console.WriteLine($"{nome} na Idade {idade} salario R$ {salario} ");


        }
    }
}
