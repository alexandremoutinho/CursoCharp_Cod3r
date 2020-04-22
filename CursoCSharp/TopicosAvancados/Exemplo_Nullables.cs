using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.TopicosAvancados {
    class Exemplo_Nullables {


        public static void Executar() {
            Nullable<int> num1 = null;
            int? num2 = null;

            if (num1.HasValue) { Console.WriteLine($"Valor de Um num: {num1}"); } else { Console.WriteLine("A Variável não possui valor."); }

            int valor = num2 ?? 1000; // Usando Int com valor Nulo ?? e o Valor = Valor padrão caso o num2 seja Null
            Console.WriteLine($"Valor: {valor}");
            bool? booleana = null;
            bool resultado = booleana.GetValueOrDefault();
            Console.WriteLine($"Resultado Bool: {resultado}");

            try {
                int x = num1.GetValueOrDefault();
                int y = num2.GetValueOrDefault();
                Console.WriteLine(x + y);

            } catch (Exception ex) { Console.WriteLine(ex.Message); }


        }//fim Executar
    }
}
