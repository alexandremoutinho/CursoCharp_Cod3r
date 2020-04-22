using System;
using System.IO;

namespace CursoCSharp.API {
    class ExemploTimeSpan {

        public static void Executar() {

            var intervalo = new TimeSpan(days: 10, hours: 20, minutes: 30, seconds: 40);

            Console.WriteLine(intervalo);
            Console.WriteLine($"Minutos: {intervalo.Minutes}");
            Console.WriteLine($"Minutos: {intervalo.TotalMinutes.ToString("F0")}");

            var largada = DateTime.Now;
            var chegada = DateTime.Now.AddMinutes(15);
            var tempo = chegada - largada;
            Console.WriteLine($"Duração: {tempo}");

            Console.WriteLine($"ToString: {intervalo.ToString("g")}");
            Console.WriteLine($"ToString: {intervalo.ToString("G")}");
            Console.WriteLine($"ToString: {intervalo.ToString("c")}");
            Console.WriteLine($"Parse: {TimeSpan.Parse("01:03:10").TotalMinutes}");


        }
    }
}
