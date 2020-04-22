using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    public class CarroOpcional {

        double desconto = 0.1;
        string nome;
        public string Nome { 
            get { return "Opcional: " + nome; }
            set { nome = value; }
        }
        // Propriedades Autoimplementadas.
        public double Preco { set; get; }

        //Somente Leitura 
        public double PrecoComDesconto {
           get => Preco - (desconto * Preco); // Lambda
           // get { return Preco - (desconto * Preco); }
        }
        public CarroOpcional() {

        }
        public CarroOpcional(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }
    }


    class Props_Propriedades {
        public static void Executar() {
            Console.WriteLine("|------------------------------------------------------------|");
            Console.WriteLine("|============<			 Seção 05 			  >=============|");
            Console.WriteLine("|========< Classes & Metodos - Atributos Estaticos >=========|");
            Console.WriteLine("|------------------------------------------------------------|");
            Console.WriteLine();
            
            //-----------------------------------------< Código da Aula >---------------------------------//

            var op_01 = new CarroOpcional("Arcondicionado", 3499.9);
            Console.WriteLine($"{op_01.Nome} Valor {op_01.Preco.ToString("C")}");
            Console.WriteLine($"Valor Com Desconto: {op_01.PrecoComDesconto.ToString("C")}");

            var op_02 = new CarroOpcional();
            op_02.Nome = "Direção Eletrica";
            op_02.Preco = 3950.40;
            
            Console.WriteLine();
            Console.WriteLine($"{op_02.Nome} Valor {op_02.Preco.ToString("C")}");
            Console.WriteLine($"Valor Com Desconto: {op_02.PrecoComDesconto.ToString("C")}");


        }//Fim do Executar

    }
}
