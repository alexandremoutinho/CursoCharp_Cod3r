using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes {
    class Exemplo_Lambda {

        public static void Executar() {

            Action algoNoConsole = () =>{ Console.WriteLine("Lambda Com C#");};
            Console.Write("Usando Action:"); algoNoConsole();

            Func<int> Jogardardo = () => {
                Random random = new Random();
                return random.Next(1, 7);
            };
            Console.WriteLine("Usando Func: {0}", Jogardardo()); ;
            
            Func<int, string> conversorHex = numero => numero.ToString("X");
            Console.WriteLine($"Converso Hexadecimal: {conversorHex(1234)}");

            Func<int, int, int, string> formatarData = (dia, mes, ano) => string.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);
            Console.WriteLine($"Função data: {formatarData(02,06,2020)}");
        }//fim do Executar

       
    }
}
