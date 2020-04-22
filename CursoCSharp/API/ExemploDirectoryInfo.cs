using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CursoCSharp.API {
    class ExemploDirectoryInfo {

        public static void Executar() {

            var dirProject = @"~/OneDrive/DEV/_CursoCSharp/".ParseHome();

            var dirInfo = new DirectoryInfo(dirProject);

            if (!dirInfo.Exists) { dirInfo.Create(); }

            Console.WriteLine("\n------------< Arquivos >-----------------\n");
            var arquivos = dirInfo.GetFiles();
            foreach (var arquivo in arquivos) { Console.WriteLine(arquivo); }

            Console.WriteLine("\n------------< Diretórios  >-----------------\n");
            var pastas = dirInfo.GetDirectories();
            foreach (var pasta in pastas) { Console.WriteLine(pasta); }

            Console.WriteLine("\n------------< Diretórios  Info >-----------------\n");
            Console.WriteLine("Info: {0}", dirInfo.FullName);
            Console.WriteLine("Info: {0}", dirInfo.CreationTime);
            Console.WriteLine("Info: {0}", dirInfo.Root);
            Console.WriteLine("Info: {0}", dirInfo.Parent);
            Console.WriteLine("Info: {0}", dirInfo.Parent.Parent);
        }


    }
}
