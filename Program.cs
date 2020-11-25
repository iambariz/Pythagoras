using System;

namespace Pythagorean
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give hypotenuse side");
            double cSide = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please give known side side");
            double aSide = Convert.ToDouble(Console.ReadLine());
            double bSide = (cSide * 2) - (aSide * 2);
            Console.WriteLine(bSide);

        }
    }
}
