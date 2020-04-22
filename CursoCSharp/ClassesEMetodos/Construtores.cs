using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    
    class Carro {

        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro(string modelo,string fabricante, int ano) {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }
        public Carro() { }
    }
    
    
    class Construtores {

         public static void Executar() {
            Console.WriteLine("|------------------------------------------------------------|");
            Console.WriteLine("|============<			 Seção 05 			  >=============|");
            Console.WriteLine("|============< Classe e Metodos - Construtores >=============|");
            Console.WriteLine("|------------------------------------------------------------|");
            //-----------------------------------------< Código da Aula >---------------------------------//

            var car01 = new Carro();
            car01.Fabricante = "BMW";
            car01.Modelo = "FX350";
            car01.Ano = 2020;
            Console.WriteLine($"Fabricante {car01.Fabricante} Modelo {car01.Modelo} Ano de Fabricação {car01.Ano}");

            var car02 = new Carro("Logan","Renault",2010);
            Console.WriteLine($"Fabricante {car02.Fabricante} Modelo {car02.Modelo} Ano de Fabricação {car02.Ano}");

            var car03 = new Carro() {
                Fabricante = "Fiat",
                Modelo = "Estilo",
                Ano = 2015
            };
            Console.WriteLine($"Fabricante {car03.Fabricante} Modelo {car03.Modelo} Ano de Fabricação {car03.Ano}");








            //--------------------------------------------------------------------------------------------//
            // Repetir Executar Local
            string digite = null;
            bool continuar = false;
            Console.Write("para Repetir  todo o procedimento Precione (S)  ");
            digite = Console.ReadLine();
            continuar = digite.ToLower() == "s";
            if (continuar == true) {
                Console.Clear();
                Executar();
            }

        }//Fim do Executar

    }
}
