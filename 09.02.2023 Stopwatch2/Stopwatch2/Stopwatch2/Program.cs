using System.Diagnostics;

namespace Stopwatch2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stopwatch");

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < 1000; i++)
            {
                System.Threading.Thread.Sleep(10);
                Console.WriteLine(i);
            }

            stopwatch.Stop();

            Console.WriteLine("Time elapsed: {0:hh\\:mm\\:ss}",
                stopwatch.Elapsed);
        }
    }
}