using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class ParametrosPorReferencia {
        
        public static void AltRef(ref int numero) {
            numero = numero + 1000;
        }
        public static void AltOut(out double numero , out double percentual) {
            Console.Write("Digite o Valor: ");
            numero = Double.Parse(Console.ReadLine());
            Console.Write("Digite o %: ");
            percentual = Double.Parse(Console.ReadLine());
            percentual = percentual / 100;
            numero = numero - numero * percentual;
        }
        public static void Executar() {

            int a = 3;
            AltRef( ref a);
            Console.WriteLine($"Por Ref.: {a}");

            //int b = 5;
            AltOut(out double b, out double c);
            Console.WriteLine($"Por Out.:{b.ToString("C")} {c.ToString("P")}");

            a = (int)b;
            AltRef(ref a);
            Console.WriteLine($"Por Ref.: {a.ToString("C")}");
        }
    }
}
