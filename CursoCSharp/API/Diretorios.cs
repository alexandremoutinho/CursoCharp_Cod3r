using System;
using System.IO;

namespace CursoCSharp.API {
    class Diretorios {

        public static void Executar() {

            var novoDir = @"~/Dir_CSharp_new".ParseHome();
            var novoDirDestino = @"~/Dir_CSharp_Destino".ParseHome();
            var dirProject = @"~/OneDrive/DEV/_CursoCSharp/".ParseHome();

            if (Directory.Exists(novoDir)) {
                Directory.Delete(novoDir, true);

            }
            if (Directory.Exists(novoDirDestino)) {
                Directory.Delete(novoDirDestino, true);

            }

            Directory.CreateDirectory(novoDir);
            Console.WriteLine(Directory.GetCreationTime(novoDir));
            Directory.CreateDirectory(novoDirDestino);
            Console.WriteLine(Directory.GetCreationTime(novoDirDestino));
            Console.WriteLine("\n----------------< Pastas >------------------\n");
            var pastas = Directory.GetDirectories(dirProject);
            
            foreach (var pasta in pastas) { Console.WriteLine(pasta);}
            
            Console.WriteLine("\n----------------< Listagem de Arquivos >------------------\n");
            var arquivos = Directory.GetFiles(dirProject);
            foreach (var file in arquivos) {Console.WriteLine(file); }

            Console.WriteLine("\n----------------< Diretório Raiz >------------------\n");
            Console.WriteLine(Directory.GetDirectoryRoot(novoDir));

            //Directory.Move(novoDir, novoDirDestino);
            


        }
    }
}
