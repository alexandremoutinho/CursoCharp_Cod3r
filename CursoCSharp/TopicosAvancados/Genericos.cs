using System;
using CursoCSharp.ClassesEMetodos;

namespace CursoCSharp.TopicosAvancados {

    public class Caixa<G> {
        G valorPrivado;
        public G Coisa { get; set; }
        public Caixa(G coisa) {
            Coisa = coisa;
            valorPrivado = coisa;
        }

        public G metodoGenerico(G valor) {
            return new Random().Next(0, 2) == 0 ? Coisa : valor;
        }

        public G GetValor() { return valorPrivado; }


    }// fim de G

    class CaixaInt : Caixa<int> {
        public CaixaInt() : base(0) { }
    }

    class CaixaProduto : Caixa<Produto> {
        public CaixaProduto() : base(new Produto()) { }
    }

    class Genericos {
        public static void Executar() {

            var cx1 = new Caixa<int>(1000);
            var cx2 = new Caixa<string>("Construtor");

            Console.WriteLine("-------------< Caixa 1 >----------- ");
            Console.WriteLine(cx1.metodoGenerico(33));
            Console.WriteLine(cx1.Coisa.GetType());
            
            Console.WriteLine("-------------< Caixa 2 >----------- ");
            Console.WriteLine(cx2.metodoGenerico("Método"));
            Console.WriteLine(cx2.Coisa.GetType());

            Console.WriteLine("-------------< Caixa 3 >----------- ");
            CaixaProduto cx3 = new CaixaProduto();
            Console.WriteLine(cx3.Coisa.GetType().Name);




        }// fim Generico
    }
}
