using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    interface Ponto {
        void MoverDiagonal(int delta);
    }

    struct Coordenada: Ponto {
        public int Y;
        public int X;

        public Coordenada(int x, int y) {
            X = x;
            Y = y;
        }
       public void MoverDiagonal(int delta) {
            X += delta;
            Y += delta;
        }
    }
    class Struct {

        public static void Executar() {
            Console.WriteLine("|------------------------------------------------|");
            Console.WriteLine("|=================< Seção 05 >===================|");
            Console.WriteLine("|========< Classes & Metodos - Struc >===========|");
            Console.WriteLine("|------------------------------------------------|");
            //-----------------------------------------< Código da Aula >---------------------------------//

            Coordenada coordenadaInical;
            coordenadaInical.X = 2;
            coordenadaInical.Y = 2;

            Console.WriteLine($"X = {coordenadaInical.X}");
            Console.WriteLine($"Y = {coordenadaInical.Y}");

            var coordenadaFinal = new Coordenada(x: 9, y: 1);
            coordenadaFinal.MoverDiagonal(10);
            Console.WriteLine("Coordenada Final: ");

            Console.WriteLine($"X = {coordenadaFinal.X}");
            Console.WriteLine($"Y = {coordenadaFinal.Y}");




        }//Fim do Executar
    }
}
