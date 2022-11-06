using System;
using System.Linq;

namespace Palindromo_teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com palidromo");
            var palavra = Console.ReadLine();

            var resultado = PalavraPalidromoUsandoLinq(palavra);
            var resultadoComFor = PalavraPalidromoUsandoFor(palavra);

            Console.WriteLine("Testar se a palavra é palidromo com LINQ: " + resultado);
            Console.WriteLine("Testar se a palavra é palidromo com FOR: " + resultadoComFor);

            Console.ReadKey();
        }

        private static int PalavraPalidromoUsandoLinq(string palavra) 
        {
            var newPalavra = palavra
                .ToList()
                .SequenceEqual(palavra.Reverse());

            return newPalavra == true ? 1 : 0;
        }

        private static int PalavraPalidromoUsandoFor(string palavra)
        {
            var contarPalavra = palavra.Length;
            var novaPalavra = string.Empty;

            for (int i = contarPalavra; i > 0; i--)
            {
                novaPalavra += palavra[i - 1];
            }

            return palavra == novaPalavra ? 1 : 0;
        }
    }
}
