using System;
using System.Globalization;

namespace Salario_com_bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo customCulture = (CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";

            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            var nome = Console.ReadLine();

            double salario = double.Parse(Console.ReadLine());

            double montanteVendido = double.Parse(Console.ReadLine());

            double totalSalario = NovoValorDeComissao(salario, montanteVendido);

            Console.WriteLine("TOTAL = R$ " + string.Format("{0:0.00}", totalSalario));

            Console.ReadKey();
        }

        private static double NovoValorDeComissao(double salario, double montanteDasVendas)
        {
            return (salario + (montanteDasVendas * 0.15));
        }
    }
}
