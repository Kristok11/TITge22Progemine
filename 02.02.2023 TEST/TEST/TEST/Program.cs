using System.Net.NetworkInformation;

namespace TEST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Koosta neli funktsiooni, millest igaüks arvutab ja 
            //väljastab ühe geomeetrilise kujundi(ruut, 
            //ring või teemant, ristkylik, kolmnurk) 
            //kujundi "*" sümbolina(vastavalt võimalusele 
            //arvutab ja väljastab viimaks ka ümbermõõdu, 
            //pindala jne).Loo programm, mis küsib kasutajalt 
            //kujundi tüüpi sõna valikuna, kujundi andmeid
            //(vastavalt vajadusele külje pikkust, raadiust vms).

            Console.WriteLine("Sisesta kujund: ");
            Console.WriteLine("1. Ruut");
            Console.WriteLine("2. Teemant");
            Console.WriteLine("3. Ristkülik");
            Console.WriteLine("4. Kolmnurk");

            string tehe = Console.ReadLine();

            switch (tehe)
            {
                case "kujund":

                    break;
                default:
                    Console.WriteLine("Valikut ei tehtud");
                    break;
            }
        }
    }
}