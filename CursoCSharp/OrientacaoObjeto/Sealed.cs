using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {

    public sealed class SemFilho { public double VlrDaFortuna() { return 1_407_033.65; } }
    //class SouFilho : SemFilho { }; - Quano é Selada não pode ser udada com Herança

    class Avo { public virtual bool HonrarFamilia() { return true; } }
    class Pai : Avo { public override sealed bool HonrarFamilia() { return true; } }

    class FilhoRebelde : Pai {/* public new bool HonrarFamilia() { return false; } */ }


    class Sealed {

        public static void Executar() {

            SemFilho semfilho = new SemFilho();
            Console.WriteLine(semfilho.VlrDaFortuna().ToString("C")); ;

            FilhoRebelde filho = new FilhoRebelde();
            Console.WriteLine(filho.HonrarFamilia());
        }


    }
}
