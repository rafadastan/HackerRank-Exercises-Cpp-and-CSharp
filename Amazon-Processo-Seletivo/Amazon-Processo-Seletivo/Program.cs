using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace Amazon_Processo_Seletivo
{
    class Result
    {
        public static int countFamilyLogins(List<string> logins)
        {
            int offset = 1 % 26;

            int count = 0;

            string newPhrase = "";

            List<string> NewPhrase = new List<string>();

            for (int i = 0; i < logins.Count; i++)
            {
                var value = logins[i];

                for (int j = 0; j < value.Length; j++)
                {
                    var newValue = value[j] + offset;

                    newPhrase += Char.ConvertFromUtf32(newValue);
                }
                NewPhrase.Add(newPhrase);
                newPhrase = String.Empty;
            }

            foreach (var item in NewPhrase)
            {
                foreach (var itens in logins)
                {
                    if (item == itens)
                    {
                        ++count;
                    }
                }
            }

            return count;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<string> logins = new List<string>();

            logins.Add("bag"); //cbh
            logins.Add("sfe"); //tgf
            logins.Add("cbh"); //dci
            logins.Add("cbh"); //dci
            logins.Add("red"); //sfe

            int result = Result.countFamilyLogins(logins);

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
