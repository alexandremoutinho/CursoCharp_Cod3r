using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    public class Produto {

        public string Nome;
        public double Preco;
        public static double Desconto = 0.1;

        public Produto(string nome, double preco, double desconto) {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }
        public Produto() {}

        public double Calc_Desconto() { return Preco - Preco * Desconto; }
    }

    class AtributosEstaticos {

        public static void Executar() {
            Console.WriteLine("|------------------------------------------------------------|");
            Console.WriteLine("|============<			 Seção 05 			  >=============|");
            Console.WriteLine("|========< Classes & Metodos - Atributos Estaticos >=========|");
            Console.WriteLine("|------------------------------------------------------------|");

            var produto_01 = new Produto("Notebook", 1600, 0.1);
            var produto_02 = new Produto() {
                Nome = "TV29p",
                Preco = 1300.00,
            };

            Console.WriteLine($"Produto {produto_01.Nome} Valor {produto_01.Preco} com Desconto: {produto_01.Calc_Desconto()}");
            Console.WriteLine($"Produto {produto_02.Nome} Valor {produto_02.Preco} com Desconto: {produto_02.Calc_Desconto()}");

            Produto.Desconto = 0.5;

            Console.WriteLine($"Produto {produto_01.Nome} Valor {produto_01.Preco} com Desconto: {produto_01.Calc_Desconto()}");
            Console.WriteLine($"Produto {produto_02.Nome} Valor {produto_02.Preco} com Desconto: {produto_02.Calc_Desconto()}");
            
            Produto.Desconto = 0.02;

            Console.WriteLine($"Produto {produto_01.Nome} Valor {produto_01.Preco} com Desconto: {produto_01.Calc_Desconto()}");
            Console.WriteLine($"Produto {produto_02.Nome} Valor {produto_02.Preco} com Desconto: {produto_02.Calc_Desconto()}");



        }
    }
}
