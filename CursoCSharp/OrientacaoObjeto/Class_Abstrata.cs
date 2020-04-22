using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace CursoCSharp.OO {
    class Class_Abstrata {

        public abstract class Celular {

            public abstract string Assistente();
            public string Tocar() { return "Trim,Trim,Trim";}
                       
        }

        public class Samsumg : Celular {
            public override string Assistente() {
                return "Olá! Meu nome é Bixby";
            }
        }

        public class IPhone : Celular {
            public override string Assistente() {
                return "Olá! Meu nome é Siri";
            }
        }

        public static void Executar() {

            var celulares = new List<Celular> { new IPhone(),new Samsumg() };

            foreach (var item in celulares) {
                Console.WriteLine(item.Assistente());
            }


            
        }
    }
}
