using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
  class ColecoesSet {
        public static void Executar() {

            var livro = new Produto("Gam Of Throne",59.9,10);

            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto>{
                new Produto("Camiseta", 25, 2),
                new Produto("Camiseta", 25, 2),
                new Produto("DVD-Blury-Avenger Utimato", 26,1),
                new Produto("8º Temporada do Game Of Thrones",101.90,1),
                
            };

            carrinho.UnionWith(combo);
            Console.WriteLine(carrinho.Count);

            //carrinho.RemoveAt(3);

            int total_pd = 0;
            double vlr_total = 0;
            foreach (var item in carrinho) {

                
                Console.WriteLine($"Item {item.Nome} |Preço: {item.Preco.ToString("C")} |Qtde:{item.Qtde} ");
                total_pd += item.Qtde;
                vlr_total += item.Preco;
            }
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Fechamento do Pedido: Valor: {0} Qtde: {1}",vlr_total.ToString("C"),total_pd);
            Console.WriteLine("---------------------------------------------------");
            
            /*O Item Add abaixo não será inclusi pois na modalidade HashSet não aceita 2 itens igual */
            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro); 
            Console.WriteLine(carrinho.Count);
        }
    }
}
