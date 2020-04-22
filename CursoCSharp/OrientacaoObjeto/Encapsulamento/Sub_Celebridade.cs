using System;
using System.Collections.Generic;
using System.Text;

namespace Emcapsulamento {
    public class Sub_Celebridade {

        // Todos - Public

        public string InfoPublica = "Tenho um Instagram!";

        // Herança

        protected string CorDosOlhos = "Verde";

        // mesmo projeto (assembly)

        internal ulong NumeroCelular = 5541998337212;

        // Herança ou Mesmo Projeto

        protected internal string JeitoDeFalar = "Uso Muitas Girias!!";

        // mesma class ou herança no mesmo projeto (C# vesão >=7.2 para funcionar)
        private protected string SegredoDeFamilia = "Bla Bla";

        // private é o Padrão

        bool UsaMuitoPhotoShop = true;

        public void MeusAcessos() {

            Console.WriteLine("SubCelebridade...\n");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDosOlhos);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoDeFamilia);
            Console.WriteLine(UsaMuitoPhotoShop);


        }

    }
}
