namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 4, 6, 8, 10 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine("----------------------");
             //liitsime 10 [hikut juurde ja algas loendamist 
             //alates 12-st
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i] = numbers[i] + 10);
            }
        }
    }
}