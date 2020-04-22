using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresLogicos {
        public static void Executar() {

            var Exe_trab_01 = false;
            var Exe_trab_02 = false;

            bool comprouTV50 = Exe_trab_01 && Exe_trab_02;
            Console.WriteLine($"Comprou a TV50? {comprouTV50}");
            
            bool comprouTV32 = Exe_trab_01 ^ Exe_trab_02;
            Console.WriteLine($"Comprou a TV32? {comprouTV32}");

            bool comprouSorvente = Exe_trab_01 || Exe_trab_02;
            Console.WriteLine($"Tomou Sorvete ? {comprouSorvente}");

            Console.WriteLine($"Mais Saudavel ? {!comprouSorvente}");



        }
    }
}
