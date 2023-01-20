namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teksti muutmine");

            string sentence = "    terE Maailm";
            int sentenceLength;
            sentenceLength = sentence.Length;

            Console.WriteLine("\n\nTulemused\n\n");
            Console.WriteLine("Teksti pikkus: {0}", sentenceLength);
            Console.WriteLine("Teksti pikkus: {0}", sentence.Length);

            Console.WriteLine("Uus lause substring: {0}", sentence.Substring(0, 6));
            Console.WriteLine("Uus lause insert: {0}", sentence.Insert(0, "olololololo"));
            Console.WriteLine("Uus lause remove: {0}", sentence.Remove(0, 6));
            Console.WriteLine("Uus lause replace: {0}", sentence.Replace("terE Maailm", "Hello Kitty"));

            Console.WriteLine("Uus lause ToLower: {0}", sentence.ToLower());
            Console.WriteLine("Uus lause ToLower: {0}", sentence.ToUpper());
            Console.WriteLine("Uus lause esimene täht suureks: {0}", char.ToUpper(sentence[0]) + sentence.Substring(1));
            Console.WriteLine("Uus lause Trim: {0}", sentence.Trim());
            Console.WriteLine("Uus lause Trim: {0}", sentence.TrimEnd());
        }
    }
}