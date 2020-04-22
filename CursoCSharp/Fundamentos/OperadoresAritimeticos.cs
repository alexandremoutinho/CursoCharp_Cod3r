using System;

namespace CursoCSharp {
    class OperadoresAritimeticos {

        public static void Executar() {
            // Preço com Desconto
            var preco = 1000.00;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;

            var totalDDesconto = total - (total * desconto);

            Console.WriteLine($"O Preço com Imposto: {total.ToString("C")} \nO Preço com Desconto {totalDDesconto.ToString("C")} \nValor de Desconto Concedido: {(total - totalDDesconto).ToString("C")}");

            //Calculo IMC

            double peso = 130.2;
            double altura = 1.80;
            double imc = peso / Math.Pow(altura,2);
            Console.WriteLine($"IMC: {imc.ToString("#.##")}");

            // Numero Par Ou Impar
            int par = 24;
            int impar = 55;
            Console.WriteLine("{0} / 2 tem o resto {1} ", par, par%2);
            Console.WriteLine("{0} / 2 tem o resto {1} ", impar, impar%2);



        }
    }
}
