using System;
using System.Collections.Generic;
using System.Linq;

namespace Find_Max_Products_Processo_Seletivo_Amazon
{
    class Result
    {
        public static long findMaxProducts(List<int> products)
        {
            var sum = products[0];

            foreach (var product in products)
            {
                var multiplication = product;

                foreach (var prod in products)
                {
                    sum = Math.Max(sum, multiplication);
                    multiplication *= prod;
                }
                sum = Math.Max(sum, multiplication);
            }

            return sum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<int> products = new List<int>();

            products.Add(1);
            products.Add(2);
            products.Add(3);
            products.Add(4);
            products.Add(5);
            products.Add(6);
            products.Add(7);

            long result = Result.findMaxProducts(products);

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
