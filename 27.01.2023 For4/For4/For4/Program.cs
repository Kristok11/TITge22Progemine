namespace For4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Ülesanne:
            >>>>>>>>>>
            Loo funktsioon, mis saab argumendina ette täisarvu ja 
            trükib ekraanile sama suure
            arvu tärne. Koosta programm, mis kutsub seda 
            funktsiooni välja 30 korda
            juhuslike positiivsete täisarvudega, mis on 
            väiksemad kui 20. Näiteks:
            ************
            *********
            **********************
            *******
            */

            Console.WriteLine("Hello, World!");

            int stringRowMin = 0;
            int stringRowMax = 5;

            int[] asterisk = new int[stringRowMax];

            Random randomAsterisk = new Random();

            for (int i = stringRowMin; i < asterisk.Length; i++)
            {
                Console.WriteLine(string.Concat(Enumerable.Repeat
                    ("*", randomAsterisk.Next(1, 20))));
            }
        }
    }
}