using Aul08VS;
using System;

namespace Aul08VS
{
    class Program
    {
        static void Main(string[] args)

        {
            Cachorro Scooby;

            Console.WriteLine("Hello word!");
            Cachorro Scooby = new Cachorro("Scooby", "marrom", 7);

            Scooby = new Cachorro();
            Scooby.Nome = "Scooby";
            Scooby.Cor = "marrom";
            Scooby.Tamanho = 7;

            Console.WriteLine($"Cachorro é o {Scooby.Nome} de cor {Scooby.Cor} e tem o tamanho {Scooby.Tamanho}");

            Scooby.comer("De tudo");

            Console.WriteLine(retorno);

            
        }
    }
}
