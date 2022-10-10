using System;
namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double x , y;
            x = 2.7;
            y = Math.Log(x + Math.Sqrt(Math.Pow(x, 2) + 9)) - ((x + 1) / (Math.Atan(Math.Pow(x, 3))));
            Console.WriteLine("y=: {0}", Math.Round(y, 4));
            Console.ReadLine();
        }
    }
}
