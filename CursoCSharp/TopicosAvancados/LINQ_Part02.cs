using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp.TopicosAvancados {


    class LINQ_Part02 {

        public static void Executar() {

            var alunos = new List<Aluno> {
                new Aluno(){Nome="Alexandre Moutinho", Idade = 39,Nota = 9.0},
                new Aluno(){Nome="Cristiane Moutinho", Idade = 36,Nota = 10},
                new Aluno(){Nome="Cristiane Moutinho", Idade = 36,Nota = 9.6},
                new Aluno(){Nome="Cida Kimita", Idade = 38,Nota = 8.0},
                new Aluno(){Nome="Rodrigo Camargo", Idade = 35,Nota = 8.8},
                new Aluno(){Nome="Antonio Souza", Idade = 51,Nota = 9.5},
                new Aluno(){Nome="Dulcira Torres", Idade = 62,Nota = 9.5},
                new Aluno(){Nome="Marcio Nobrega", Idade = 38,Nota = 6.5}
            };

            var alexandre = alunos.Single(aluno => aluno.Nome.Equals("Alexandre Moutinho"));

            Console.WriteLine($"Aluno: {alexandre.Nome} Nota: {alexandre.Nota.ToString("F2")}");

            var fulano = alunos.SingleOrDefault(aluno => aluno.Nome.Equals("Fulano"));
            if (fulano == null) { Console.WriteLine("Aluno não Localizado"); }

            var cris = alunos.First(aluno => aluno.Nome.Equals("Cristiane Moutinho"));
            Console.WriteLine($"Aluno: {cris.Nome} Nota: {cris.Nota}");

            var sicrano = alunos.FirstOrDefault(aluno => aluno.Nome.Equals("Sicrano"));
            if (sicrano == null) { Console.WriteLine("Aluno não Localizado"); }


            var expSkip = alunos.Skip(1).Take(3);
            foreach (var item in expSkip) { Console.WriteLine(item.Nome); }

            var MaiorNota = alunos.Max(aluno => aluno.Nota);
            Console.WriteLine($" Nota: {MaiorNota}");  
            var MenorNota = alunos.Min(aluno => aluno.Nota);
            Console.WriteLine($" Nota: {MenorNota}");

            var somatorioNotas = alunos.Sum(aluno => aluno.Nota);
            Console.WriteLine(somatorioNotas);

            var MediaDaTurmaGeral = alunos.Average(aluno => aluno.Nota);
            Console.WriteLine($"Media Turma Geral: {MediaDaTurmaGeral.ToString("F2")}");
            //Media apenas dos alunos Aprovados 
            var MediaDaTurmaAprovados = alunos.Where(a=>a.Nota>=7).Average(aluno => aluno.Nota);
            Console.WriteLine($"Media Dos Aprovados: {MediaDaTurmaAprovados.ToString("F2")}");
            


        }//Fim Executar
    }
}
