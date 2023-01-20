namespace TemperatuurCelsius
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta temperatuur Celsiuses: ");
            string temp = Console.ReadLine();
            double parsedTemp = Double.Parse(temp);

            Console.WriteLine("\n\nSisesta tuule kiirus: ");
            string windSpeed = Console.ReadLine();
            double windSpeedParsed = Double.Parse(windSpeed);

            Console.WriteLine("\n\nSisesta õhuniiskus: ");
            double humidityParsed= Double.Parse(Console.ReadLine());
            //double humidityParsed = Double.Parse(humidity);

            double tempFeelsLike = parsedTemp + (0.33 * ((humidityParsed / 100 * 6.105 * Math.Exp
                (17.27 * parsedTemp / (237.7 + parsedTemp)))) - (0.7 * (windSpeedParsed / 5)))
                - 4;

            Console.WriteLine("Tajutav temp on: {0}", tempFeelsLike);
        }
    }
}