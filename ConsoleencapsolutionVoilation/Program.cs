using ConsoleencapsolutionVoilation.Domain;
using System;


namespace ConsoleencapsolutionVoilation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle big = new Rectangle();
            big.width = 1000;
            big.color = "pink";
            big.height = -100;
            //PrintInfo(big);


            Console.WriteLine("Printing Rectangle Info .......");
            Console.WriteLine();
            Console.WriteLine("width is " + big.width);
            Console.WriteLine("height is " + big.height);
            Console.WriteLine("height is " + big.color);
            Console.WriteLine("Area is " + big.CalculateArea());
            Console.WriteLine("Hashcode is " +big.GetHashCode());


            Rectangle Small = new Rectangle();
            Small.width = 1000;
            Small.color = "red";
            Small.height = -100;
            //PrintInfo(big);


            Console.WriteLine("Printing Rectangle Info .......");
            Console.WriteLine();
            Console.WriteLine("width is " + Small.width);
            Console.WriteLine("height is " + Small.height);
            Console.WriteLine("height is " + Small.color);
            Console.WriteLine("Area is " + Small.CalculateArea());
            Console.WriteLine("Hashcode is " + Small.GetHashCode());
        }
    }
}
