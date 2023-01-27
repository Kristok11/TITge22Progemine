namespace ForFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci numbers");
            Console.WriteLine("Sisesta numbrid");
            int n = Convert.ToInt32(Console.ReadLine());
            int t, prv = 0, pre = 1;

            for (int i = 3; i <= n; i++)
            {
                t = prv + pre;
                Console.Write(" {0} ", t);
                prv = pre;
                pre=t;
            }
            Console.Write("\n");
        }
    }
}