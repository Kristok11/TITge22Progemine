namespace Array4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] animals = { "Cat", "Alligator", "Fox", "Donkey", 
                "Bear", "Elephant", "Goat" };

            //Array.Sort(animals);
            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine(animals[i]);
            }

            Console.WriteLine("------------------------");
            Console.WriteLine("Sorteerib kolme esimest elementi " +
                "animals muutuja seast. Ülejäänud kuvab, nii" +
                "nagu olen need massiivi sisestanud");
            Array.Sort(animals, 0, 3);
            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine(animals[i]);
            }

            Console.WriteLine("------------------------");
            //muutuja numbers on võti ja selle taga olev numberNames
            // on väärtus. Array.Sort-s viiakse need omavahel kokku
            int[] numbers = { 2, 1, 4, 3 };
            string[] numberNames = { "two", "one", "four", "three" };

            Array.Sort(numbers, numberNames);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            for (int i = 0; i < numberNames.Length; i++)
            {
                Console.WriteLine(numberNames[i]);
            }
            Console.WriteLine("-------------------------------");
            Array.Reverse(animals);
            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine(animals[i]);
            }
        }
    }
}