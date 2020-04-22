using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEmcapsulamento {
    public class AmigoProximo {

        public readonly Sub_Celebridade amiga = new Sub_Celebridade();

        public void MeusAcessos() {
            Console.WriteLine("Amigo Proximo...\n");

            Console.WriteLine(amiga.InfoPublica);
            //Console.WriteLine(amiga.CorDosOlhos);
            Console.WriteLine(amiga.NumeroCelular);
            Console.WriteLine(amiga.JeitoDeFalar);
            //Console.WriteLine(amiga.SegredoDeFamilia);
            //Console.WriteLine(UsaMuitoPhotoShop);
        }
    }
}
