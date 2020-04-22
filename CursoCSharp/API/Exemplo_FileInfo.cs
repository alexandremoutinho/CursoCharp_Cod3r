using System;
using System.IO;


namespace CursoCSharp.API {
    class Exemplo_FileInfo {


        public static   void ExcluirSeExistir(params string[] caminhos) {
            foreach (var caminho in caminhos) {
                FileInfo arquivo = new FileInfo(caminho);
                if (arquivo.Exists) { arquivo.Delete(); }
            }
        }
        public static void Executar() {

            var caminhoOrigem = @"~/OneDrive/DEV/_CursoCSharp/file/arq_origem.txt".ParseHome();
            var caminhoDestino = @"~/OneDrive/DEV/_CursoCSharp/file/arq_destino.txt".ParseHome();
            var caminhoCopy = @"~/OneDrive/DEV/_CursoCSharp/file/arq_copy.txt".ParseHome();

            ExcluirSeExistir(caminhoOrigem, caminhoDestino, caminhoCopy);
            
            using(StreamWriter file = File.CreateText(caminhoOrigem)) {
                file.WriteLine("Ariquivo Original");
            }

            FileInfo origem = new FileInfo(caminhoOrigem);
            Console.WriteLine(origem.Name);
            Console.WriteLine(origem.IsReadOnly);
            Console.WriteLine(origem.FullName);
            Console.WriteLine(origem.Extension);
            Console.WriteLine(origem.Length);
            Console.WriteLine(origem.DirectoryName);

            origem.CopyTo(caminhoCopy);
            origem.MoveTo(caminhoDestino);

        }//fim Executar
    }
}
