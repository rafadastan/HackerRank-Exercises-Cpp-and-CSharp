using System;
using System.Globalization;

namespace Salario_beecrowd
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo customCulture = (CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";

            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            var number = double.Parse(Console.ReadLine());

            var salary = double.Parse(Console.ReadLine());

            var QuantityPerHoursWork = double.Parse(Console.ReadLine());

            double SalaryTotal = (salary * QuantityPerHoursWork);

            Console.WriteLine("NUMBER = " + number);
            Console.WriteLine("SALARY = U$ " + string.Format("{0:0.00}", SalaryTotal));

            Console.ReadKey();
        }
    }
}
