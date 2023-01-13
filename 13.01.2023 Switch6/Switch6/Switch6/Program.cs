namespace Switch6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kohvik Fantaasia!");

            Console.WriteLine("Kohvi valik");
            Console.WriteLine("1. Väike tass");
            Console.WriteLine("2. Keskmine tass");
            Console.WriteLine("3. Suur tass");

            Console.WriteLine("\n\npalun tee valik numbriga: ");

            byte selection = byte.Parse(Console.ReadLine());

            double price = 0;

            switch (selection)
            {
                case 1:
                    price = price + 0.8; 
                    break;

                case 2:
                    price = price + 1.20;
                    break;

                case 3:
                    //sama hea, mis: price = price + 1.20;
                    price += 2; 
                    break;

                default:
                    Console.WriteLine("\nVale. Valikut ei tehtud.");
                    break;
            }

            if (price != 0)
            {
                //kommimis koht
                Console.WriteLine("\n\nTuleb maksta {0:f2} eurot.", price);
            }
        }
    }
}