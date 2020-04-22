using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes {


    class ColecoesArrayList {
        public static void Executar() {

            var arrylist = new ArrayList {"Livro",3,39.6,true};
            arrylist.Add(false);

            foreach (var item in arrylist) {
                Console.WriteLine("{0} tipo --> {1}",item,item.GetType());
            }

        }
    }
}
