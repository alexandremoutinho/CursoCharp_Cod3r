using System;
namespace CursoCSharp.Fundamentos
{
    public class OperadorTernario
    {
       public static void Executar(){
           var nota =9.0;
           bool bom_Comportamento = false;
           string resultado = nota >=7.0 && bom_Comportamento? "Aprovado":"Reprovado";
           Console.WriteLine(resultado);

       } 
    }
}