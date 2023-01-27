namespace For6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolmnurk tähtedest");
            Console.WriteLine("Sisesta ridade arv:");

            int rows = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                Console.Write("\n");
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" *");
                }
            }
        }
    }
}