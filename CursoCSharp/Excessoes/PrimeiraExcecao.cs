using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Excessoes {

    public class Conta {

        double Saldo;
        public Conta(double saldo) { Saldo = saldo; }

        public void Sacar(double valor) {
            if (valor > Saldo) { throw new AggregateException(" SALDO INSUFICIENTE !!"); }

            Saldo -= valor;
        }       

    }
    class PrimeiraExcecao {



        public static void Executar() {

            var conta = new Conta(1_450.45);
            try {

                conta.Sacar(1500);
                Console.WriteLine("Retira Efetuado com Sucesso!!!");

            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            } finally { Console.WriteLine("Operação Finaliza Obrigado!"); }



        }
    }
}
