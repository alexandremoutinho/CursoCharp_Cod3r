using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes {
    
    

    class Usuando_Delegate {


        delegate double Soma(double a, double b);
        delegate void PrintSoma(double a, double b);
        static double MinhaSoma(double a, double b) { return a + b; }

        static void PrintMinhaSoma(double a, double b) { Console.WriteLine(a + b); }


        public static void Executar() {

            Soma op1 = MinhaSoma;
            Console.WriteLine(op1(5,6.9));

            PrintSoma op2 = PrintMinhaSoma;
            op2(5.9, 10.6);

            Func<double, double, double> op3 = MinhaSoma;
            Console.WriteLine( op3(5.9,2));

        }
    }
}
