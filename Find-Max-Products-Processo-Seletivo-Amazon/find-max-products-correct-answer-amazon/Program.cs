using System;

namespace find_max_products_correct_answer_amazon
{

    class Result
    {

        static int maxSubarrayProduct(int[] arr)
        {
            int result = arr[0];
            int n = arr.Length;

            for (int i = 0; i < n; i++)
            {
                int mul = arr[i];

                for (int j = i + 1; j < n; j++)
                {
                    result = Math.Max(result, mul);
                    mul *= arr[j];
                }

                result = Math.Max(result, mul);
            }
            return result;
        }

        public static void Main(String[] args)
        {
            int[] arr = { 1, -2, -3, 0, 7, -8, -2 };

            Console.Write("Maximum Sub array product is " +
                          maxSubarrayProduct(arr));
            
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
