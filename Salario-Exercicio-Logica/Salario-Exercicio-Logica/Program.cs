using System;
using System.Globalization;

namespace Salario_Exercicio_Logica
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo cultureInfo = new CultureInfo("en-us");

            int numEmployee = Convert.ToInt16(Console.ReadLine());
            int workedHours = Convert.ToInt16(Console.ReadLine());
            double valueHours = Convert.ToDouble(Console.ReadLine());

            double salary = workedHours * valueHours;

            Console.Write($"NUMBER = {numEmployee}\n", cultureInfo.NumberFormat);
            Console.Write($"SALARY = U$ {salary:N2:#}\n", cultureInfo.NumberFormat);

            Console.ReadKey();
        }
    }
}
