using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {

    public class Produto {
        public string Nome;
        public double Preco;
        public int Qtde;
       
        public Produto(string nome, double preco, int qtde) {
            Nome = nome;
            Preco = preco;
            Qtde = qtde;
        }

        public override bool Equals(object obj) {
            return obj is Produto produto &&
                   Nome == produto.Nome &&
                   Preco == produto.Preco &&
                   Qtde == produto.Qtde;
        }

        public override int GetHashCode() {
            return HashCode.Combine(Nome, Preco, Qtde);
        }
    }

    class ColecoesList {
        public static void Executar() {

            var livro = new Produto("Gam Of Throne",59.9,10);

            var carrinho = new List<Produto>();
            carrinho.Add(livro);

            var combo = new List<Produto>{
                new Produto("Camiseta", 25, 2),
                new Produto("DVD-Blury-Avenger Utimato", 26,1),
                new Produto("8º Temporada do Game Of Thrones",101.90,1)
            };

            carrinho.AddRange(combo);
            Console.WriteLine(carrinho.Count);

            carrinho.RemoveAt(3);
            int total_pd = 0;
            double vlr_total = 0;
            foreach (var item in carrinho) {

                
                Console.WriteLine($"Item {carrinho.IndexOf(item)} {item.Nome} |Preço: {item.Preco} |Qtde:{item.Qtde} ");
                total_pd += item.Qtde;
                vlr_total += item.Preco;
            }
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Fechamento do Pedido: Valor: {0} Qtde: {1}",vlr_total.ToString("C"),total_pd);
            Console.WriteLine("---------------------------------------------------");
            
        }
    }
}
