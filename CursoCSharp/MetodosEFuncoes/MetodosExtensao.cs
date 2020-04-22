using System;


namespace CursoCSharp.MetodosEFuncoes {

    public static class ExtensoesInteiro {
        public static int Soma(this int num, int outroN) { return num + outroN; }
        public static int Subtracao(this int num, int outroN) { return num - outroN; }
    }

    class MetodosExtensao {

        public static void Executar() {

            int numero = 5;

            Console.WriteLine(numero.Soma(3));
            Console.WriteLine(numero.Subtracao(3));

            Console.WriteLine(5.Soma(9));
            Console.WriteLine(5.Subtracao(9));



        }

    }
}
