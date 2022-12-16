namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Ristküliku pindala ja ümbermõõt!");
            Console.WriteLine("Sisesta esimese külje pikkus:");

            string firstLength = Console.ReadLine();
            float firstLengthParsed = float.Parse(firstLength);

            Console.WriteLine("Sisesta teise külje pikkus:");
            double secondLength = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ristküliku ümbermõõt " + 2 * (firstLengthParsed + secondLength));
            Console.WriteLine("Ristküliku pindala " + (firstLengthParsed * secondLength));

            Console.ReadKey();
        }
    }
}