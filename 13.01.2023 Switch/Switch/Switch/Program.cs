namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Täringu veeretamine");

            int result = new Random().Next(1,6);

            switch (result)
            {
                case 1:
                    Console.WriteLine("Said ühe, oled luuser");
                    break;
                case 2:
                    Console.WriteLine("Said kahe, juba parem");
                    break;
                case 3:
                    Console.WriteLine("Said kolme, pole paha");
                    break;
                case 4:
                    Console.WriteLine("Said nelja, väga hea");
                    break;
                case 5:
                    Console.WriteLine("Said viie nagu õpilane");
                    break;
                case 6:
                    Console.WriteLine("said kuue e max punktid");
                    break;

                default:
                    Console.WriteLine("ERROR");
                    break;
            }
        }
    }
}