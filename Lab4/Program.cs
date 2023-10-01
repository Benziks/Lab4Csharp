using System;

namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector(1.3f, 2.5f, 3.6f);
            Vector v2 = new Vector(4.4f, 5.2f, 6.8f);
            Vector v3 = new Vector(7.9f, 8.4f, 9.2f);
           
            Console.WriteLine("Ваш вектор v1: " + v1.DisplayVector());
            Console.WriteLine("Ваш вектор v1: " + v2.DisplayVector());
            Console.WriteLine("Ваш вектор v1: " + v3.DisplayVector());

            //(a+b) x c. "x" Было понято как скалярное произведение %
            float r = (v1 + v2) % v3;
            Console.WriteLine($"\nСкалярное произведение v1v2 и v3 = {r}");

            Vector t = (v1 + v3) * v3;
            Console.WriteLine("\nВектор t = "+t.DisplayVector());

            Console.WriteLine("\nДлина вектора v1 равна: " + Math.Round(v1.VectorLength(),4));
            Console.WriteLine("Длина вектора v2 равна: " + Math.Round(v2.VectorLength(), 4));
            Console.WriteLine("Длина вектора v3 равна: " + Math.Round(v3.VectorLength(), 4));

            Vector resultingVector = v1 + v2 + v3;
            Console.WriteLine("\nВаш результирующий вектор = " + resultingVector.DisplayVector());

            Console.WriteLine("\nДлина результирующего вектора = " + Math.Round(resultingVector.VectorLength(), 5));

            Console.ReadLine();
        }
    }
}
