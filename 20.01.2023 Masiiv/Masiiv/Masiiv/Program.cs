namespace Masiiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string sentence = "Euroopa üks pealinnadest on: ";

            //näide 1
            var citys = Tuple.Create("Tallinn", "Pariis", "Rooma", "London", "Helsinki");
            Console.WriteLine(sentence + citys.Item4);
            Console.WriteLine("-------------");

            //näide 2
            string[] city = { "Tallinn", "Pariis", "Rooma", "London", "Helsinki" };
            for (int i = 0; i < city.Length; i++)
            {
                Console.WriteLine(sentence + city[i]);
            }
            Console.WriteLine("-------------");

            //näide 3
            string[] cityArray = { "Tallinn", "Pariis", "Rooma", "London", "Helsinki" };
            Console.WriteLine(sentence + city[3]);
            Console.WriteLine("-------------");

            //näide 4
            Random number = new Random();
            int randomNumber = number.Next(0, 4);
            Console.WriteLine(sentence + city[randomNumber]);
        }
    }
}