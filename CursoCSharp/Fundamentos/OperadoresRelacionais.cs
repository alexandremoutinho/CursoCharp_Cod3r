using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp {
    class OperadoresRelacionais {

        public static void Executar() {

            Console.Write("Informe a Nota: ");
            double.TryParse(Console.ReadLine(), out double nota);

            double notaDeCorte = 7.0;

            Console.WriteLine($"Nota Inválida? {nota > 10.0}");
            Console.WriteLine($"Nota Inválida? {nota < 0.0}");
            Console.WriteLine($"Nota Perfeito? {nota == 10.0}");
            Console.WriteLine($"Nota Tem como Melhorar? {nota != 10.0}");
            Console.WriteLine($"Passou Por Média ? {nota >= notaDeCorte}");
            Console.WriteLine($"Recuperação ? {nota <= notaDeCorte}");
            Console.WriteLine($"Reprovação ? {nota <= 3.0}");

        }

        
    }
}
