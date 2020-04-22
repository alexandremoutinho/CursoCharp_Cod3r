using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;


// usando o this e base 

namespace CursoCSharp.OO {
    class Usuando_This {

        public class Animal {
            public string Nome { get; set; }

            public Animal(string nome) {
                Nome = nome;
            }
        }

        public class Cachorro : Animal {
            public double Altura { get; set; }
            public Cachorro(string nome) : base(nome) {
                Console.WriteLine($"Cachorro {nome} inicializado");
            }
            public Cachorro (string nome, double altura) : this(nome) {
                Altura = altura;
            }

            public override string ToString() {
                return $"{Nome} tem {Altura} cm de Altura!";
            }

        }

        public static void Executar() {

            var tina = new Cachorro("Tina Linda",23);
            var nina = new Cachorro("Nina Linda", 25.00);

            Console.WriteLine(nina);
            Console.WriteLine(tina);

        }
    }
}
