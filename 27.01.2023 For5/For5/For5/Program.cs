namespace For5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Näita korrutustabelit ja sisesta korrutis!");

            int j, n;
            Console.WriteLine("-----------------------");
            Console.WriteLine("\n");

            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            for (j = 1; j <= 10; j++)
            {
                Console.WriteLine("{0} X {1} = {2}", n, j, n*j);
            }

        }
    }
}