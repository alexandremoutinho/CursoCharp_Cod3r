using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle {
    class Estrutura_FOR {


        public static void Executar() {

            Console.WriteLine("|------------------------------------------------------------|");
            Console.WriteLine("|============<			  Seção 04       	   >============|");
            Console.WriteLine("|============<   Estrutura de Controle - FOR    >============|");
            Console.WriteLine("|------------------------------------------------------------|");

            double somatorio = 0;
            string entrada;

            Console.Write("Informe o Tamanho da Turma: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoTurma);

            for (int i=1; i<= tamanhoTurma;i++) {
                Console.Write("Informe a Nota do Aluno {0}: ", i);
                entrada = Console.ReadLine();
                double.TryParse(entrada,out double notaAtual);
                somatorio += notaAtual;

            }

            double media = tamanhoTurma > 0 ? somatorio / tamanhoTurma : 0;
            Console.WriteLine("Media da Turma: {0}", media);


            }
        }
    }
