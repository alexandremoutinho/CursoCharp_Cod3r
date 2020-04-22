using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class VariaveisEConstantes {

        public static void Executar() {
            // area de circuferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;

            double area = PI * raio * raio;
            Console.WriteLine("Area é: "+ area);

            bool estaChovendo = true;

            if(estaChovendo == true) {
                Console.WriteLine("Esta Chovendo? SIM ");
            } else {
                Console.WriteLine("Esta Chovendo? NÃO ");
            }
            
            byte idade = 45;
            Console.WriteLine("Idade: " +  idade);
            
            sbyte saldoDGold = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols: " + saldoDGold);
            
            short salario = short.MaxValue;
            Console.WriteLine("Salario: "+salario);

            int menorValorInt = int.MinValue;
            Console.WriteLine("Menor Valor Int: "+ menorValorInt);
            
            uint populacaoBrasileira =207_600_000;
            Console.WriteLine("População Brasileira Int: "+ populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor Valor Long: " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População Mudial: " + populacaoMundial);

            float precoComputador = 1299.99f;
                        Console.WriteLine("Preço do Computador: " + precoComputador);

            double vlrMercadoApple = 1_000_000_000_000.00;
            Console.WriteLine("Valor de Mercado da Apple: "+vlrMercadoApple);

            decimal distancia = decimal.MaxValue;
            Console.WriteLine("Distancia Percorrida: " + distancia);

            char letra = 'b';
            Console.WriteLine("Letra : "+ letra );

            string texto = "Seja Bem Vindo ao Curso de C#";
            Console.WriteLine(texto);


        }
    }
}
