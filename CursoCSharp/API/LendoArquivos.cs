using System;
using System.IO;


namespace CursoCSharp.API {
    class LendoArquivos {

        public static void Executar() {
            var path = @"~/OneDrive/DEV/_CursoCSharp/file/lendo_arquivo.txt".ParseHome();
            

            if (!File.Exists(path)) {

                using (StreamWriter file = File.AppendText(path)) {
                    file.WriteLine("Produto;Preco;Qdte");
                    file.WriteLine("NoteBook;1535.36;10");
                    file.WriteLine("Teclado;135.60;8");

                }

            }

            try {
                using (StreamReader file = new StreamReader(path)) {
                    var texto = file.ReadToEnd();
                    Console.WriteLine(texto);
                }
            } catch (Exception excessao) { Console.WriteLine(excessao.Message); }
        }
    }
}
