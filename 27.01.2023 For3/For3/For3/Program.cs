namespace For3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kill - koll kill - koll killadi - koll kill - 
            //koll kill - koll killadi - koll kill - 
            //koll kill - koll kill - koll
            //kill - kol

            Console.WriteLine("Palun sisesta korduste arv:");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine("See on rida nr {0}", i);
                string a = "kill-koll";
                string b = "killadi-koll";

                for (int g = 1; g <= 2; g++)
                {
                    Console.WriteLine(a);
                }
                for (int k = 1; k <= 1; k++)
                {
                    Console.WriteLine(b);
                }
            }
        }
    }
}