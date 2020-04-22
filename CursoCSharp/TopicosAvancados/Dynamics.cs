using System;




namespace CursoCSharp.TopicosAvancados {
    class Dynamics {

        public static void Executar() {

            dynamic MeuObjeto = "teste";
            MeuObjeto = 3;
            MeuObjeto++;

            Console.WriteLine($"Meu Objeto {MeuObjeto}");

            dynamic aluno = new System.Dynamic.ExpandoObject();

            aluno.nome = "Dulcira Torres Pereira";
            aluno.nota = 9.6;
            aluno.idade = 62;

            Console.WriteLine($"Aluno: {aluno.nome} tem a Idade de {aluno.idade} nota atual {aluno.nota}");

        }
    }
}
