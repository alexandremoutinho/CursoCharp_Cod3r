using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    public class Dependente {
        public string Nome;
        public int Idade;

    }
    class ValorVsReferencia {

        public static void Executar() {
            
            Console.WriteLine("Atribuição de Valor vs Referência!\n");
            
            
            int numero = 3;
            int copy_numero = numero;

            Console.WriteLine("------------< Atribuição de Valor >---------------\n");

            Console.WriteLine($"Valor de N = {numero} Valor de Copy = {copy_numero}");
            numero++;
            Console.WriteLine($"Valor de N = {numero} Valor de Copy =  {copy_numero}");

            Console.WriteLine("\n-----------< Atribuição de Referência >---------\n");

            Dependente dep = new Dependente { Nome = "Alexandre", Idade = 30 };
            Dependente copy_dep = dep;

            Console.WriteLine($"DEP -->  Nome = {dep.Nome} Idade =  {dep.Idade}");
            Console.WriteLine($"Copy-DEP -->  Nome = {copy_dep.Nome} Idade =  {copy_dep.Idade}\n");

            copy_dep.Nome = "Cristiane Moutinho";
            copy_dep.Idade = 36;

            Console.WriteLine($"DEP -->  Nome = {dep.Nome} Idade =  {dep.Idade}");
            Console.WriteLine($"Copy-DEP -->  Nome = {copy_dep.Nome} Idade =  {copy_dep.Idade}\n");
            
            Console.WriteLine("\n-----------< Fim >---------\n");

        }
    }
}
