using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {

    public class Carro {

        protected readonly int VelocidadeMaxima;
        int VelocidadeAtual;

        public Carro(int velocidadeMaxima) {
            VelocidadeMaxima = velocidadeMaxima;
        }
        public int AlterarVelocidade(int delta) {
            int novaVelocidade = VelocidadeAtual + delta;

            if (novaVelocidade < 0) {
                VelocidadeAtual = 0;
            } else if (novaVelocidade > VelocidadeMaxima) {
                VelocidadeAtual = VelocidadeMaxima;
            } else { VelocidadeAtual = novaVelocidade; }
            return VelocidadeAtual;
        }

        public virtual int Acelerar() {return AlterarVelocidade(5);}
        public  int Frear() {return AlterarVelocidade(-5);}

    }// fim da class Carro

    public class Uno : Carro {public Uno() : base(185) { }  
    }//Fim da Class Uno
    public class Ferrari : Carro {public Ferrari() : base(350) { }  

        public  override int Acelerar() {
            return AlterarVelocidade(15);
        }
        // Ocultando o método da class Pai
        public new int Frear() {
            return AlterarVelocidade(-15);
        }

    }//Fim da Class Ferrari

    class Heranca {

        public static void Executar() {

            int acelerarx = 2;
            int desacelerar = 3;
            // Usando UNO
            Console.WriteLine("Veiculo: UNO...");
            Uno car_01 = new Uno();
                      

            for (int i=0;i<=acelerarx;i++) {
                Console.WriteLine($"Acelerando{i}:{car_01.Acelerar()} ");
                
            };

            for (int i = 0; i < desacelerar; i++) {
                Console.WriteLine($"Desacelerando: {car_01.Frear()}");
            }

            // Usando a Ferrare
            Console.WriteLine("Veiculo: Ferrari...");
            Ferrari car_02 = new Ferrari();


            for (int i = 0; i <= acelerarx; i++) {
                Console.WriteLine($"Acelerando{i}:{car_02.Acelerar()} ");

            };

            for (int i = 0; i < desacelerar; i++) {
                Console.WriteLine($"Desacelerando: {car_02.Frear()}");
            }
            // Usando Ferrari com o tipo Carro

            Console.WriteLine("Ferrari com o Tipo Carro...");

            Carro car_03 = new Ferrari(); // Isso é Um Polimorfismo.

            for (int i = 0; i <= acelerarx; i++) {
                Console.WriteLine($"Acelerando{i}:{car_03.Acelerar()} ");

            };

            for (int i = 0; i < desacelerar; i++) {
                Console.WriteLine($"Desacelerando: {car_03.Frear()}");
            }

            Console.WriteLine("UNO com o Tipo Carro...");
            car_03 = new Uno(); // Isso é Um Polimorfismo.

            for (int i = 0; i <= acelerarx; i++) {
                Console.WriteLine($"Acelerando{i}:{car_03.Acelerar()} ");

            };

            for (int i = 0; i < desacelerar; i++) {
                Console.WriteLine($"Desacelerando: {car_03.Frear()}");
            }


        }
    }
}
