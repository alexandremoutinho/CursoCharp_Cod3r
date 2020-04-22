using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes {
    class ColecoesQueue {

        public static void Executar() {

            var fila = new Queue<string>();

            fila.Enqueue("Alexandre Moutinho");
            fila.Enqueue("Alexandre Moutinho");
            fila.Enqueue("Cristiane Moutinho");
            fila.Enqueue("Sueli Martins");

            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count);
            
            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count);
            foreach (var item in fila) {Console.WriteLine(item);}

            var salada = new Queue();
            salada.Enqueue(3);
            salada.Enqueue("Teste");
            salada.Enqueue(true);
            salada.Enqueue(3.15);

            Console.WriteLine(salada.Contains("Teste"));
        }

    }
}
