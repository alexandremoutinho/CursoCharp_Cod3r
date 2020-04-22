using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
    class ColecaoDictionary {

        public static void Executar() {

            var filmes = new Dictionary<int, string>();
            filmes.Add(2000,"Gladiador");
            filmes.Add(2015,"Thor Rangnarok");
            filmes.Add(2018,"Avenger Guerra Infinita");
            filmes.Add(2019,"Avenger Ultimato");
            
            
            if (filmes.ContainsKey(2019)) {
                Console.WriteLine($"2019: {filmes[2019]}");
                Console.WriteLine($"2019: {filmes.GetValueOrDefault(2000)}");
            } else { Console.WriteLine("Não conte o filme!"); }

            Console.WriteLine(filmes.ContainsValue("Rei Leão"));
            Console.WriteLine($"Removeu? {filmes.Remove(2005)}");

            filmes.TryGetValue(2015, out string filme2015);
            Console.WriteLine($"Filme {filme2015}");

            foreach (var chave in filmes.Keys) { Console.WriteLine($"Chave: {chave}"); }
            foreach (var valor in filmes.Values) { Console.WriteLine($"Valor: {valor}"); }

            Console.WriteLine("\nLista de for 01:");
            foreach (KeyValuePair<int,string> filme in filmes) {
                Console.WriteLine($"{filme.Value} é de {filme.Key}");
            }
            Console.WriteLine("\nLista de for 02:");
            foreach (var filme in filmes) { Console.WriteLine($"{filme.Value} é de {filme.Key}"); }
            
        
        
        
        
        }
    }
}
