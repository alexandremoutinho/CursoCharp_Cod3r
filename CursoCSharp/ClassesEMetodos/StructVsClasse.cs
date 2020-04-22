using System;

namespace CursoCSharp.ClassesEMetodos {

    public struct SPonto {
        public int X;
        public int Y;

    }

    public class CPonto {
        public int X;
        public int Y;
    }

    class StructVsClasse {

        public static void Executar() {

            //Struct faz Atribuição por VALOR:

            Console.WriteLine("\nSTRUCT = Atribuição por VALOR \n");
            SPonto ponto1 = new SPonto { X = 1, Y=3 };
            Console.WriteLine($"Valor do Ponto 1 = X: {ponto1.X}  Y: {ponto1.Y}");
            SPonto copyPonto1 = ponto1;
            ponto1.X = 3;
                        
            Console.WriteLine($"Valor do Ponto 1 = X: {ponto1.X}  Y: {ponto1.Y}");
            Console.WriteLine($"Valor de CopyPonto 1 = X: {copyPonto1.X}  Y: {copyPonto1.Y}");

            //Class faz Atribuição por REFERÊNCIA:

            Console.WriteLine("\nCLASS = Atribuição por REFERÊNCIA \n");

            CPonto ponto2 = new CPonto { X = 2, Y = 4 };
            Console.WriteLine($"Valor do Ponto 1 = X: {ponto2.X}  Y: {ponto2.Y}");
            CPonto copyPonto2 = ponto2;
            ponto2.X = 5;

            Console.WriteLine($"Valor do Ponto 1 = X: {ponto2.X}  Y: {ponto2.Y}");
            Console.WriteLine($"Valor de CopyPonto 1 = X: {copyPonto2.X}  Y: {copyPonto2.Y}");


        }//fim do executar.


    }
} // fim no Name Space
