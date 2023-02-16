namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dictionary");

            IDictionary<int, string> resultNames = new Dictionary<int, string>();

            resultNames.Add(1, "One");
            resultNames.Add(2, "Two");
            resultNames.Add(3, "Three");

            foreach (KeyValuePair<int, string> kvp in resultNames)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }

            Console.WriteLine("--------------------------------------------------");

            var cities = new Dictionary<string, string>()
            {
                { "EST", "Tallinn, Tartu, Pärnu" },
                { "LAT", "Riga, Daugvapils, Jurmala" },
                { "FIN", "Helisinki, Turu, Oulu" }
            };

            int i = 0;
            foreach (var kvp in cities)
            {
                i++;
                Console.WriteLine("Key: {0}, Value: {1}, {2}", kvp.Key, kvp.Value, i);
            }

            Console.WriteLine("--------------------------------------------------");

            var linnad = new Dictionary<string, string>()
            {
                { "EST", "Tallinn, Tartu, Pärnu" },
                { "LAT", "Riga, Daugvapils, Jurmala" },
                { "FIN", "Helisinki, Turu, Oulu" }
            };

            linnad["EST"] = "Võru, Paldiski";
            linnad["FIN"] = "Tampere, Porvo";

            foreach (var kvp in linnad)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }

            Console.WriteLine("--------------------------------------------------");

            linnad.Remove("EST");

            Console.WriteLine("Total Elements: {0}", linnad.Count);

            linnad.Clear();

            Console.WriteLine("Elemente peale Clear() funktsiooni kasutamist: {0}", linnad.Count);
        }
    }
}