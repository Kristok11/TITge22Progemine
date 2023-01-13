namespace Switch5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tervitus");

            int greeting = 2;

            switch (greeting)
            {
                case 1:
                    Console.WriteLine("Hello");
                    break;
                case 2:
                    Console.WriteLine("Bonjour");
                    goto case 3;
                case 3:
                    Console.WriteLine("Namaste");
                    goto default;

                default:
                    Console.WriteLine("Entered value is: " + greeting);
                    break;
            }
        }
    }
}