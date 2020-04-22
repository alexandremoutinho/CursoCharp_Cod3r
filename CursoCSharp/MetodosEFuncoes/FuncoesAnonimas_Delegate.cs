using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes {
    class FuncoesAnonimas_Delegate {

        delegate string StringOperacao(string s);

        public static void Executar() {

            StringOperacao inverter = delegate (string s) {
                char[] charArray = s.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            };

            Console.WriteLine(inverter("C# é TOP!!! E EU vou me tornar um Master neste liguagem!"));
        }
    }
}
