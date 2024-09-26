using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fakeRepo
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        
        static void CalculateCosts ( int base, int disc)
        {
            Console.WriteLine("Calculating costs...");
            Console.WriteLine("Please, insert base cost:");
            int cost = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, insert discount:");
            int discount = int.Parse(Console.ReadLine());
            Console.WriteLine("Final cost is: " + (cost + discount));
        }
    }
}
