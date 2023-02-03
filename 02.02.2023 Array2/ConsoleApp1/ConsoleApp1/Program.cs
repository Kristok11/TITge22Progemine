namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "Tallinn", "Tartu", "Rapla" };

            for (int i = 0; i < cities.Length; i++)
            {
                Console.WriteLine(cities[i]);
            }
        }
    }
}