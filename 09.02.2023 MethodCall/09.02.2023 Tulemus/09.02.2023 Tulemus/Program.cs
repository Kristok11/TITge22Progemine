namespace _09._02._2023_Tulemus
{
    internal class Program
    {
        float num, precent;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Program p = new();

            p.Accept();
            p.Print();
        }

        public void Accept()
        {
            Console.WriteLine("Sisesta hinne: ");
            num = float.Parse(Console.ReadLine());
        }

        public void Print()
        {
            precent = (float)num / 850 * 100;

            if (precent < 35)
            {
                Console.WriteLine("Sorry!!! You failed. Your mark is " + precent);
            }
            else if (precent > 35 && precent < 50)
            {
                Console.WriteLine("You got grade D and your % mark is " + precent);
            }
            else if (precent > 50 && precent < 60)
            {
                Console.WriteLine("You got grade C and your % mark is " + precent);
            }
            else if (precent > 60 && precent < 75)
            {
                Console.WriteLine("You got grade B and your % mark is " + precent);
            }
            else
            {
                Console.WriteLine("You got grade A and your % mark is " + precent);
            }
        }
    }
}