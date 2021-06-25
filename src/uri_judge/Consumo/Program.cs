using System;
using System.Globalization;
namespace Consumo
{
    class Program
    {
        static void Main(string[] args)
        {
            int X;
            double Y, Km;

            X = int.Parse(Console.ReadLine());
            Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Km = (double)X / Y;

            Console.WriteLine(Km.ToString("F3", CultureInfo.InvariantCulture) + "Km/L");

        }
    }
}
