using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp.TopicosAvancados {

    public  class Aluno {
        public string Nome;
        public int Idade;
        public double Nota;
    }
    class LINQ_Part01 {

        public static void Executar() {

            var alunos = new List<Aluno> {
                new Aluno(){Nome="Alexandre Moutinho", Idade = 39,Nota = 9.0},
                new Aluno(){Nome="Cristiane Moutinho", Idade = 36,Nota = 10},
                new Aluno(){Nome="Cida Kimita", Idade = 38,Nota = 8.0},
                new Aluno(){Nome="Rodrigo Camargo", Idade = 35,Nota = 8.8},
                new Aluno(){Nome="Antonio Souza", Idade = 51,Nota = 9.5},
                new Aluno(){Nome="Dulcira Torres", Idade = 62,Nota = 9.5},
                new Aluno(){Nome="Marcio Nobrega", Idade = 38,Nota = 6.5}

            };

            Console.WriteLine("--------------< Aprovados >---------------------");
            var aprovados = alunos.Where(a => a.Nota>7.0).OrderBy(a=>a.Nome);
            foreach (var aluno in aprovados) {
                Console.WriteLine(aluno.Nome);                
            }

            Console.WriteLine("--------------< Chamada >---------------------");
            var chamada = alunos.OrderBy(a => a.Nome).Select(a => a.Nome);

            foreach (var aluno in chamada) { Console.WriteLine(aluno); }

            Console.WriteLine("--------------< Aprovados (Por Indade) >--------------");

            var alunosAprovados = from aluno in alunos  where aluno.Nota >= 7 orderby aluno.Idade  select aluno.Nome;

            foreach (var item in alunosAprovados) { Console.WriteLine(item);}


        }
    }
}
