using System;
using System.Diagnostics;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            string number = Console.ReadLine();
            string result = string.Empty;
            int num = 0;
            if(int.TryParse(number, out num))
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                for (int i = 1; i <= num/2; i++)
                {
                    if ((num % i) == 0)
                    {
                        result += i + " ";
                    }
                }
                Console.WriteLine(result);
                sw.Stop();
                Console.WriteLine("Ticks: " + sw.ElapsedTicks);
            }
            else Console.WriteLine("Input message in uncorrect");
            Console.ReadKey();
        }
    }
}
