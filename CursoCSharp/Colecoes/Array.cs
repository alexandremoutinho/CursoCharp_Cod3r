using System;


namespace CursoCSharp.Colecoes {
    class Array {
        public static void Executar() {
            
            //Exemplo 01

            const int tm = 10;
            int regitro = 0;
            string[] alunos = new string[tm];

            alunos[0] = "Alexandre Moutinho";
            alunos[1] = "Cristiane Moutinho";
            alunos[2] = "Dulcira Torres Pereira ";
            alunos[3] = "Thais Moutinho Pedon";
            alunos[4] = "Antonio Cesar de Souza";
            alunos[5] = "Rodrigo Quintas";
            alunos[6] = "Marcio Santos";
            alunos[7] = "Jucie Silvano da Cruz";
            alunos[8] = "Antony Cavalheiro ";
            alunos[9] = "Liziano da Silva";

            foreach (var item in alunos) {
                Console.WriteLine("Id: {0} Aluno: {1}",regitro,item);
                regitro++; 
            }


            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Total de Registro: {0}",regitro);
            Console.WriteLine("-------------------------------------");
            
            Console.WriteLine();
            
            //Exemplo 02
            double somatorio = 0;
            double somanot = 0;
            double[] notas = { 9.7, 8.5, 9.8, 6, 3, 10.0 };
            foreach (var item in notas) {
                somatorio += item;
            }

            for (int i = 0; i < notas.Length; i++) {
                somanot += notas[i];
            }
            double media = somatorio / notas.Length;
            Console.WriteLine("Total de Notas {0}",somanot.ToString("F2"));
            Console.WriteLine("Media {0}",media.ToString("F2"));
            
            //Exemplo 03
            char[] letras = { 'a', 'b', 'w', 'd', 'r' };
            string palavra = new string(letras);
            Console.WriteLine("Tamanho do Array: {0}",palavra.Length);

            Console.WriteLine();

        }
    }
}
