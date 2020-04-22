using System;
using System.IO;
using System.Security.Principal;

namespace CursoCSharp.API {
    class ExemploDataTime {

        public static void Executar() {

            var dataTime = new DateTime(2030, 02, 06);

            Console.WriteLine(dataTime.Day);
            Console.WriteLine(dataTime.Month);
            Console.WriteLine(dataTime.Year);

            // para criar data automatica sem hora

            var hoje = DateTime.Today;
            Console.WriteLine(hoje);
            var diaAtual = DateTime.Now;
            Console.WriteLine("Dia Atual: {0}",diaAtual);
            Console.WriteLine("Hora Atual: {0}",diaAtual.Hour);
            Console.WriteLine("Hora Atual: {0}",diaAtual.Minute);
            var amanha = diaAtual.AddDays(30);
            Console.WriteLine(amanha);
            Console.WriteLine(diaAtual.ToString("dd"));
            Console.WriteLine(diaAtual.ToString("d"));
            Console.WriteLine(diaAtual.ToString("D"));
            Console.WriteLine(diaAtual.ToString("g"));
            Console.WriteLine(diaAtual.ToString("G"));
            Console.WriteLine(diaAtual.ToString("dd-MM-yyyy HH:mm"));


            

        }
    }
}
