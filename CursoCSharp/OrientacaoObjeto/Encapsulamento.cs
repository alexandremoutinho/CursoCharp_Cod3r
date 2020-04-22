using System;
using Emcapsulamento;


namespace CursoCSharp.OO {
    public class FilhoNaoReconhecido: Sub_Celebridade {
        public new void MeusAcessos() {

            Console.WriteLine("Filho Nao Reconhecido...\n");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDosOlhos);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoDeFamilia);
        
        }
    }   

    public class AmigoDistante {

        public readonly Sub_Celebridade amiga = new Sub_Celebridade();

        public void MeusAcessos() {
            Console.WriteLine("Filho Nao Reconhecido...\n");

            Console.WriteLine(amiga.InfoPublica);
            Console.WriteLine(amiga.NumeroCelular);
            Console.WriteLine(amiga.JeitoDeFalar);
            
        }


    }

    class Encapsulamento {

        public static void Executar() {

            Sub_Celebridade sub = new Sub_Celebridade();

            sub.MeusAcessos();
            new FilhoReconhecido().MeusAcessos();
            new AmigoProximo().MeusAcessos();
            new FilhoNaoReconhecido().MeusAcessos();
            new AmigoDistante().MeusAcessos();


            

        }
    }
}
