using System;
using ClasseInterface;

namespace ExemploInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Endereco endereco = new Endereco();
            endereco.Logradouro = "Rua Nova Esperança";
            endereco.Numero = "56";
            endereco.Bairro = "Jardim Alegria";

            PF pf = new PF(10,"Helena","2356","helena@email","4545",endereco);
            Console.WriteLine(pf.Cadastro());
        }
    }
}
