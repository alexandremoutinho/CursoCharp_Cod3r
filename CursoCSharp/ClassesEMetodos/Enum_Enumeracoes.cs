using System;

namespace CursoCSharp.ClassesEMetodos {

    public enum Genero {Ação,Aventura,Terror,Animação, Comédia};
    public class Filmes {
        public string Titulo;
        public Genero GeneroFilme;
    }

    class Enum_Enumeracoes {

        public static void Executar() {
            Console.WriteLine("|------------------------------------------------------------|");
            Console.WriteLine("|============<			 Seção 05 			  >=============|");
            Console.WriteLine("|========< Classes & Metodos - Enum - Enumerações >==========|");
            Console.WriteLine("|------------------------------------------------------------|");
            //-----------------------------------------< Código da Aula >---------------------------------//

            int id = (int)Genero.Aventura;
            Console.WriteLine($"Id do Filme: {id}");

            var filme_novo = new Filmes();
            filme_novo.Titulo = "007 Contra Todo Mundo";
            filme_novo.GeneroFilme = Genero.Ação;

            Console.WriteLine($"Titulo do Filme: {filme_novo.Titulo} | Genero: {filme_novo.GeneroFilme}");




        }//Fim do Executar
    }
}
