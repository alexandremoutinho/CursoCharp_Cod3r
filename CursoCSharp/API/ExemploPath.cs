using System;
using System.IO;


namespace CursoCSharp.API {
    class ExemploPath {
        public static void Executar() {

            var arquivo = @"~/OneDrive/DEV/_CursoCSharp/file/ex_path_arquivo.txt".ParseHome();
            var pasta = @"~/OneDrive/DEV/_CursoCSharp/file/ex_path_arquivo".ParseHome();

            if (!File.Exists(arquivo)) {

                using (StreamWriter sw = File.CreateText(arquivo)) { sw.WriteLine("Um novo Arquivo Foi Criado"); }
            }
            if (!Directory.Exists(pasta)) { Directory.CreateDirectory(pasta); }

            Console.WriteLine("-------------< Informações >-------------");
            Console.WriteLine(Path.GetExtension(arquivo));
            Console.WriteLine(Path.GetFileName(arquivo));
            Console.WriteLine(Path.GetFileNameWithoutExtension(arquivo));
            Console.WriteLine(Path.HasExtension(pasta));
            Console.WriteLine(Path.GetFullPath(pasta));
            Console.WriteLine(Path.GetPathRoot(pasta));



        }

    }
}
