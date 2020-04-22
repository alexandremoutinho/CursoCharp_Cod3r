using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes {
    class ColecoesStack {

        public static void Executar() {

            var pilha = new Stack();
            pilha.Push(3);
            pilha.Push("teste");
            pilha.Push(true);
            pilha.Push(10.35f);
            foreach (var item in pilha) {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine();

            Console.WriteLine($"\nPop:{pilha.Pop()}");

            foreach (var item in pilha) {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine($"\nPeek:{pilha.Peek()}");
            Console.WriteLine(pilha.Count);



        }
    }
}
