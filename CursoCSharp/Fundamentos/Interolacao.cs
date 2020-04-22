using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Interolacao {
        public static void Executar() {

            string nome = "Notebook Gamer";
            string marca = "Dell";
            double preco = 5800.00;

            Console.WriteLine("O "+nome + " da marca " + marca + " esta custando " + preco);
            Console.WriteLine("O {0} da Marca {1} Custa {2}", nome,marca,preco);
            Console.WriteLine($"O {nome} da Marca {marca} esta custando atualmente {preco}");
            Console.WriteLine($" 1 + 1 =  {1+1} !");

        }
    }
}
