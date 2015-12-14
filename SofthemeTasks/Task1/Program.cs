using System;
using System.Diagnostics;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString;
            int result = 0;
            try
            {
                using (TextReader tr = new StreamReader("INPUT.TXT"))
                {
                    inputString = tr.ReadLine();
                }
                Stopwatch sw = new Stopwatch();
                sw.Start();
                result = Algorithm1.FindMaxNotZeroLength(inputString);
                sw.Stop();
                Console.WriteLine("Algorithm1: result " + result + "; ticks: " + sw.ElapsedTicks);
                sw = new Stopwatch();
                sw.Start();
                result = Algorithm2.FindMaxNotZeroLength(inputString);
                sw.Stop();
                Console.WriteLine("Algorithm2: result " + result + "; ticks: " + sw.ElapsedTicks);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            TextWriter tw = new StreamWriter("OUTPUT.TXT");
            tw.WriteLine(result.ToString());
            tw.Close();
            Console.ReadKey();
        }
    }
}
