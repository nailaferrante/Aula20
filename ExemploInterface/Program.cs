using System;
using ClasseInterface;

namespace ExemploInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto pr = new Produto(/*argumentos*/){ // o que está entre  chaves é propriedade
                Id = 30,
                Nome = "Sabão",
                Descricao = "Em pó",
                Preco = 30
                // pode-se fazer assim
                // pr.Id = 30;
                // pr.Nome = "Sabão";
                // pr.Descricao = "Em pó";
                // pr.Preco = 30;
            };
            Console.WriteLine(pr.Cadastro());
        }
    }
}
