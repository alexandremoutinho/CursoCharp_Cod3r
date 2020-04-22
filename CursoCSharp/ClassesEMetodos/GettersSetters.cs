using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class GettersSetters {


        public class Moto {

            private string Marca;  
            private string Modelo;
            private uint Cilindrada; //Unit Não tem sinal assim não permitira valores negativos. 

            public Moto() {

            }

            public Moto(string marca,string modelo, uint cilindrada) {

                //Marca = marca;
                //Modelo = modelo;
                //Cilindrada = cilindrada;
                SetMarca(marca);
                SetModelo(modelo);
                SetCilidrada(cilindrada);
            }
            // Metodos Get e Set
            public string GetMarca() { return Marca; }
            public void SetMarca(string marca) { Marca = marca; }

            public string GetModelo() { return Modelo; }
            public void SetModelo(string modelo) { Modelo = modelo; }
            
            public uint GetCilidrada() { return Cilindrada; }
            public void SetCilidrada(uint cilindrada) {

                Cilindrada = cilindrada;
                
                /*
                Opção para Não deixar setar valores Negativos:
                1º --> Usar o numero inteiro como uint.
                2º --> if (cilindrada > 0) {Cilindrada = cilindrada;} 
                3º -->  Cilindrada = Math.Abs(cilindrada);
                */

            }



        }

        public static void Executar() {
            Console.WriteLine("|------------------------------------------------------------|");
            Console.WriteLine("|============<			 Seção 05 			  >=============|");
            Console.WriteLine("|========< Classes & Metodos - Getters & Setters >===========|");
            Console.WriteLine("|------------------------------------------------------------|");
            //-----------------------------------------< Código da Aula >---------------------------------//

            var moto_01 = new Moto("Honda", "Falcon", 450);

            Console.WriteLine($"Marca: {moto_01.GetMarca()} Modelo: {moto_01.GetModelo()} CC: {moto_01.GetCilidrada()}");

            var moto_02 = new Moto();
                        
            moto_02.SetMarca("Kawasaki");
            moto_02.SetModelo("Nija ZX-6R");
            moto_02.SetCilidrada(636);

            Console.WriteLine($"Marca: {moto_02.GetMarca()} Modelo: {moto_02.GetModelo()} CC: {moto_02.GetCilidrada()}");

        }//Fim do Executar

    }
}
