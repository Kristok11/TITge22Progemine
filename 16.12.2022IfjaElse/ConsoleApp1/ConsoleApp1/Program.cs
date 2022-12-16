namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "If ja else";
            Console.WriteLine("Kasutaja kontroll");
            Console.WriteLine("Palun sisesta oma nimi: ");
            string name = Console.ReadLine();

            Console.WriteLine("Palun sisesta vanus: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Tere {0}, oled {1} aastane.", name, age);
            //muutujad on taga
            Console.WriteLine("Tere " + name + ", oled " + age + " aastane.");
            //muutujad on stringi vahel
            Console.WriteLine($"Tere {name}, oled {age} aastane."); 
            //string format

            if (age < 7)
            {
                Console.WriteLine("Loodan, et sa käid juba koolis.");
            }
            else if (age >= 7 && age <= 18)
            {
                Console.WriteLine("Nüüd peaksid kindlasti koolis käima.");
            }
            else if (age >= 19 && age <= 75)
            {
                Console.WriteLine("Oled vist juba tööl.");
            }
            else if (age >= 75 && age < 120)
            {
                Console.WriteLine("Loodan, et puhkad kuskil soojal saarel.");
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}