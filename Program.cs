using System;
using System.Globalization;
namespace Area_Do_Triangulo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Triangulo x = new Triangulo();
            Triangulo y = new Triangulo();

            x.EntradaDeDadosTrianguloX();

            y.EntradaDeDadosTrianguloY();

            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            if (areaX > areaY)
            {
                Console.Clear();
                Console.WriteLine($"\nMaior área é X: \nÁrea de X: [{areaX.ToString("F2", CultureInfo.InvariantCulture)}]" +
                    $" \nÁrea de Y: [{areaY.ToString("F2", CultureInfo.InvariantCulture)}]");
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"\nMaior área é Y: \nÁrea de Y: [{areaY.ToString("F2", CultureInfo.InvariantCulture)}]" +
                    $" \nÁrea de X: [{areaX.ToString("F2", CultureInfo.InvariantCulture)}]");
            }
        }

        internal class Triangulo
        {
            public double A { get; set; }
            public double B { get; set; }
            public double C { get; set; }

            public void EntradaDeDadosTrianguloX()
            {
                Console.WriteLine("Entre com as medidas do triângulo X: ");
                A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            public void EntradaDeDadosTrianguloY()
            {
                Console.WriteLine("Entre com as medidas do triângulo Y: ");
                A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

        }
    }
}

