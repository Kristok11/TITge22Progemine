namespace While3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("While3");

            int i = 0;
            int j = 1;

            while (i < 10)
            {
                Console.WriteLine("i = {0}", i);

                i++;

                while (j < 3)
                {
                    Console.WriteLine("j = {0}", j);

                    j++;
                }
            }
        }
    }
}