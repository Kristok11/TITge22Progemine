namespace IfNesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "If nesting";
            Console.WriteLine("If nesting");
            Console.WriteLine("Mis pilet sulle sobib?");
            Console.WriteLine("Sisesta inimese vanus (täisarv): ");

            int age = int.Parse(Console.ReadLine());

            if (age < 21)
            {
                if (age < 7)
                {
                    Console.WriteLine("\nSulle piletit ei ole vaja!");
                }
                else if (age >= 7 && age <= 14)
                {
                    Console.WriteLine("\nSulle on lapsepilet!");
                }
                else if (age > 14 && age < 21)
                {
                    Console.WriteLine("Tuleb osta täispilet");
                }
            }
            else if (age >= 21 && age <= 125)
            {
                Console.WriteLine("Maksa topelt!!! Teenid juba raha!");
            }
            else 
            {
                Console.WriteLine("ERROR!");
            }
        }
    }
}