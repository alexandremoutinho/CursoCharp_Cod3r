using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEmcapsulamento {
    public class FilhoReconhecido : Sub_Celebridade {

        public new void MeusAcessos() {

            Console.WriteLine("Filho Reconhecimento...\n");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDosOlhos);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoDeFamilia);
            //Console.WriteLine(UsaMuitoPhotoShop);
        }
    }
}
