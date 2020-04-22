using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excessoes;
using CursoCSharp.API;
using CursoCSharp.TopicosAvancados;

namespace CursoCSharp {
    class Program {
        public static void Main(string[] args) {
            Console.Clear();
            string digite = null;
            bool continuar = true;

            Console.WriteLine("|------------------------------------------------------------|");
            Console.WriteLine("|=======< Curso de C# Pela COD3R - Plataforma Udemy >========|");
            Console.WriteLine("|------------------------------------------------------------|");
            while (continuar == true) {
                var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos 
                {"Seção 03 - Fundamentos ---> Primeiro Programa", PrimeiroPrograma.Executar},
                {"Seção 03 - Fundamentos ---> Comentários", Comentarios.Executar},
                {"Seção 03 - Fundamentos ---> Variaveis e Constantes", VariaveisEConstantes.Executar},
                {"Seção 03 - Fundamentos ---> Inferencia", Inferencia.Executar},
                {"Seção 03 - Fundamentos ---> Interpolação", Interolacao.Executar},
                {"Seção 03 - Fundamentos ---> Notação Ponto", NotacaoPonto.Executar},
                {"Seção 03 - Fundamentos ---> Lendo Dados", LendoDados.Executar},
                {"Seção 03 - Fundamentos ---> Formatando Números", FormatandoNumero.Executar},
                {"Seção 03 - Fundamentos ---> Conversões", Conversoes.Executar},
                {"Seção 03 - Fundamentos ---> Operadores Aritimeticos", OperadoresAritimeticos.Executar},
                {"Seção 03 - Fundamentos ---> Operadores Relacionais", OperadoresRelacionais.Executar},
                {"Seção 03 - Fundamentos ---> Operadores Lógicos", OperadoresLogicos.Executar},
                {"Seção 03 - Fundamentos ---> Operadores de Atribuição ", OperadoresAtribuicao.Executar},
                {"Seção 03 - Fundamentos ---> Operadores de Unarios ", OperadoresUnarios.Executar},
                {"Seção 03 - Fundamentos ---> Operadore Ternario ", OperadorTernario.Executar},
                //Estruturas de Controle
                {"Seção 04 - Estrutura de Controle ---> Estrutura - IF ", Estrutura_If.Executar},
                {"Seção 04 - Estrutura de Controle ---> Estrutura - IF Else ", Estrutura_IfElse.Executar},
                {"Seção 04 - Estrutura de Controle ---> Estrutura - IF Else IF ", Estrutura_IfElseIF.Executar},
                {"Seção 04 - Estrutura de Controle ---> Estrutura - SWITCH  ", Estrutura_Switch.Executar},
                {"Seção 04 - Estrutura de Controle ---> Estrutura - WHILE  ", Estrutura_While.Executar},
                {"Seção 04 - Estrutura de Controle ---> Estrutura - DO WHILE  ", Estrutura_DoWhile.Executar},
                {"Seção 04 - Estrutura de Controle ---> Estrutura - FOR  ", Estrutura_FOR.Executar},
                {"Seção 04 - Estrutura de Controle ---> Estrutura - FOREACH  ", Estrutura_Foreach.Executar},
                {"Seção 04 - Estrutura de Controle ---> Estrutura - Usando BREAK  ", Usuando_Break.Executar},
                {"Seção 04 - Estrutura de Controle ---> Estrutura - Usando Continue  ", Usuando_Continue.Executar},

                //Classes & Métodos
                {"Seção 05 - Classes & Métodos ---> Membros - Atributos e Métodos", Membros.Executar},
                {"Seção 05 - Classes & Métodos ---> Construtores", Construtores.Executar},
                {"Seção 05 - Classes & Métodos ---> Métodos com Retorno", MetodosComRetorno.Executar},
                {"Seção 05 - Classes & Métodos ---> Métodos Estáticos", MetodosEstaticos.Executar},
                {"Seção 05 - Classes & Métodos ---> Atribos Estáticos", AtributosEstaticos.Executar},
                {"Seção 05 - Classes & Métodos ---> Desafio de Atributo", DesafioAtributo.Executar},
                {"Seção 05 - Classes & Métodos ---> Params", Params.Executar},
                {"Seção 05 - Classes & Métodos ---> Parametros Nomeados", ParametrosNomeados.Executar},
                {"Seção 05 - Classes & Métodos ---> Getters & Setters", GettersSetters.Executar},
                {"Seção 05 - Classes & Métodos ---> Props --> Propriedades", Props_Propriedades.Executar},
                {"Seção 05 - Classes & Métodos ---> Atributos Readonly", AtributosReadonly.Executar},
                {"Seção 05 - Classes & Métodos ---> Enum - Enumerações", Enum_Enumeracoes.Executar},
                {"Seção 05 - Classes & Métodos ---> Struct ", Struct.Executar},
                {"Seção 05 - Classes & Métodos ---> Struct Vs Classe ", StructVsClasse.Executar},
                {"Seção 05 - Classes & Métodos ---> Valor Vs Referência ", ValorVsReferencia.Executar},
                {"Seção 05 - Classes & Métodos ---> Parametros por Referência ", ParametrosPorReferencia.Executar},
                {"Seção 05 - Classes & Métodos ---> Parametros Padrão ", ParametroPadrao.Executar},
                
                //Coleções    
                {"Seção 06 - Coleções ---> Array", Colecoes.Array.Executar},
                {"Seção 06 - Coleções ---> List", ColecoesList.Executar},
                {"Seção 06 - Coleções ---> ArrayList", ColecoesArrayList.Executar},
                {"Seção 06 - Coleções ---> Set", ColecoesSet.Executar},
                {"Seção 06 - Coleções ---> Queue (Fila)", ColecoesQueue.Executar},
                {"Seção 06 - Coleções ---> Igualdade", Igualdade.Executar},
                {"Seção 06 - Coleções ---> Stack", ColecoesStack.Executar},
                {"Seção 06 - Coleções ---> Dictionary", ColecaoDictionary.Executar},

                //OO - Orientação ao Objeto.

                {"Seção 07 - OO ---> Herança", Heranca.Executar},
                {"Seção 07 - OO ---> Usuando o This", Usuando_This.Executar},
                {"Seção 07 - OO ---> Emcapsulamento", Encapsulamento.Executar},
                {"Seção 07 - OO ---> Polimorfismo", Polimorfismo.Executar},
                {"Seção 07 - OO ---> Classe Abstrata", Class_Abstrata.Executar},
                {"Seção 07 - OO --->  Interface ", Interface.Executar},
                {"Seção 07 - OO --->  Classe e Método Sealed ", Sealed.Executar},
                                   
                    
                //Metodos e Funções Seção 08.
                {"Seção 08 - Metodos & Funçoes  ---> Lambda", Exemplo_Lambda.Executar},
                {"Seção 08 - Metodos & Funçoes  ---> Delegate com Lambda",Delegate_Lambda.Executar},
                {"Seção 08 - Metodos & Funçoes  ---> Delegate",Usuando_Delegate.Executar},
                {"Seção 08 - Metodos & Funçoes  ---> Delegate e Funções Anonimas",FuncoesAnonimas_Delegate.Executar},
                {"Seção 08 - Metodos & Funçoes  ---> Delegate como Parametros",Delegate_ComoParametros.Executar},
                {"Seção 08 - Metodos & Funçoes  ---> Métodos de Extensão",MetodosExtensao.Executar},
                
                //Exceções
                {"Seção 09 - Exceções ---> 1º Exceção ",PrimeiraExcecao.Executar},
                {"Seção 09 - Exceções ---> Exceção Personalizadas ",ExcecoesPersonalizadas.Executar},
                
                //APIs
                {"Seção 10 - APIs ---> 1º Arquivo ",PrimeiroArquivo.Executar},
                {"Seção 10 - APIs ---> Lendo Arquivo ",LendoArquivos.Executar},
                {"Seção 10 - APIs ---> Exemplo File Info ",Exemplo_FileInfo.Executar},
                {"Seção 10 - APIs ---> Diretórios   ",Diretorios.Executar},
                {"Seção 10 - APIs ---> Directory Info ",ExemploDirectoryInfo.Executar},
                {"Seção 10 - APIs ---> Exemplo Path ",ExemploPath.Executar},
                {"Seção 10 - APIs ---> Exemplo Data Time ",ExemploDataTime.Executar},
                {"Seção 10 - APIs ---> Exemplo Time Span ", ExemploTimeSpan.Executar},

                //Tópicos Avançados
                {"Seção 11 - Tópicos Avançados ---> LINQ#1 ", LINQ_Part01.Executar},
                {"Seção 11 - Tópicos Avançados ---> LINQ#2 ", LINQ_Part02.Executar},
                {"Seção 11 - Tópicos Avançados ---> Nullables ", Exemplo_Nullables.Executar},
                {"Seção 11 - Tópicos Avançados ---> Dynamics ", Dynamics.Executar},


            });

            
            central.SelecionarEExecutar();
            Console.Write("para Repetir  todo o procedimento Precione (S)  ");
            digite = Console.ReadLine();
            continuar = digite.ToLower() == "s";
                       
            }
            Console.Clear();
            Console.WriteLine("|------------------------------------------------------------|");
            Console.WriteLine("|=======< Curso de C# Pela COD3R - Plataforma Udemy >========|");
            Console.WriteLine("|=======<                    Fim!                   >========|");
            Console.WriteLine("|------------------------------------------------------------|");
        }
    }
}