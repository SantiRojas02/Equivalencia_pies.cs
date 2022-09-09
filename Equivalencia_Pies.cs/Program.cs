using System;

namespace Equivalencia_Pies.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int pies, metros, yardas;
            
            Console.Write("Ingrese distancia en pies: ");
            int distancia = Convert.ToInt32(Console.ReadLine());
            double pulgada = 2.54;
            pies = 12 * distancia;
            yardas = 3 * distancia;
            pulgada = 2.54 * distancia;
            metros = 100 * distancia;

            Console.WriteLine("Equivalente en yardas: "+ yardas);
            Console.WriteLine("Equivalente en pulgadas: "+ pulgada);
            Console.WriteLine("Equivalente en metros: "+ metros);

            Console.ReadKey();

        }
    }
}
