using System;

namespace CursoCSharp.OO {

    public class Comida {
        public double Peso;
        public Comida (double peso) {
            Peso = peso;
        }
        public Comida() { }

    }

    public class Feijao :Comida { public Feijao(double peso) : base(peso) { } }
    public class Arroz: Comida  { public Arroz(double peso) : base(peso) { } }
    public class Carne : Comida { public Carne(double peso) : base(peso) { } }

    public class Pessoa {
        public double Peso;
        public void Comer(Comida comida) { Peso += comida.Peso; }
    }

    class Polimorfismo {

        public static void Executar() {


            Feijao ingrediente1 = new Feijao(.3);
            Arroz ingrediente2 = new Arroz(.25);
            Carne ingrediente3 = new Carne(.4);

            
            Pessoa cliente = new Pessoa();
            cliente.Peso = 80.20;
            cliente.Comer(ingrediente1);
            cliente.Comer(ingrediente2);
            cliente.Comer(ingrediente3);

            Console.WriteLine($"Seu peso Agora está {cliente.Peso} kg!");

        }

    }

}