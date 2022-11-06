using System;
using System.Linq;

namespace Teste_Neon
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1. Escreva um algoritmo que receba um texto como entrada e precisará retornar 
             * se ele é ou não um palíndromo. Sendo 1 para o caso de ser palíndromo e 0 quando não for.
             * 
             * afa
                aia
                aibofobia
                ala
                ama
                ana
                anilina
                ata
                arara
                asa
                ele
             * 
             */

            Console.WriteLine("Entre com uma frase palidromo: ");
            var palavraPalidromo = Console.ReadLine();

            var recebePalavraInversa = string.Empty;
            var resultado = palavraPalidromo.Length;

            for (int i = resultado; i > 0; i--)
            {
                recebePalavraInversa += palavraPalidromo[i - 1].ToString();
            }

            var verificaResultado = ReturnValue(palavraPalidromo, recebePalavraInversa);

            Console.WriteLine("É uma palidromo: " + verificaResultado);
            Console.ReadKey();
        }

        public static int ReturnValue(string palavra, string segundaPalavra)
        {
            if (palavra.Equals(segundaPalavra))
                return 1;

            return 0;
        }
    }
}
