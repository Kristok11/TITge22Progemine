namespace Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enum");

            Console.WriteLine(WeekDays.Friday);

            int day = (int)WeekDays.Friday;
            Console.WriteLine(day);

            var weekDay = (WeekDays)4;
            Console.WriteLine(weekDay);

            int color = (int)Colors.Yellow;
            Console.WriteLine(color);

            //lubab ainult neid väärtuseid sisestada,
            //mis on enum classis defineeritud
            //See annab errorit
            //int colorWrongNr = (Colors)1;
            //Console.WriteLine(colorWrongNr);
        }

        enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        enum Colors
        {
            Red = 3,
            Green = 10,
            Blue = 13,
            Yellow = 5,
            Black = 1,
            White = 8
        }
    }
}