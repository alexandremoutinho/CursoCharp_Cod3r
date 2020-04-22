using System;
using System.IO;

namespace CursoCSharp.API {

    public static class ExtensaoString {

        public static string ParseHome(this string path) {
            string home = Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            return path.Replace("~", home);
        }


    }

    class PrimeiroArquivo {

        public static void Executar() {
            var path = @"~/OneDrive/DEV/_CursoCSharp/file/primeiro_arquivo.txt".ParseHome();

            if (!File.Exists(path)) {
                using (StreamWriter sw = File.CreateText(path)) {
                    sw.WriteLine("Este é o ");
                    sw.WriteLine("Meu Primeiro ");
                    sw.WriteLine("Arquivo");
                }                        
            }

            using (StreamWriter sw = File.AppendText(path)) {
                sw.WriteLine("");
                sw.WriteLine("");
            }


        }
    }
}
