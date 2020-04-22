using System;

namespace CursoCSharp.Excessoes {

    public class NegativosException : Exception {
    
        public NegativosException() { }
        public NegativosException(string message) : base(message) { }

        public NegativosException(string message, Exception inner) : base(message, inner) { }

    }

    public class ImparException : Exception {
        public ImparException(string message) : base(message) { }
    }

    class ExcecoesPersonalizadas {

        public static int PositivoPar() {
            Random random = new Random();
            int valor = random.Next(-10, 10);

            if(valor < 0) {throw new NegativosException("Número Negativo...:(");}
            if(valor %2 == 1) { throw new ImparException("Valor Impar...("); }
            return valor;
        }


        public static void Executar() {

            try { Console.WriteLine(PositivoPar()); } catch (NegativosException ex) { Console.WriteLine(ex.Message); } catch (ImparException ex) { Console.WriteLine(ex.Message); }

        }
    }
}
