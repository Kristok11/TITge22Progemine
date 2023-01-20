namespace While2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("While2");

            byte i = 0;
            //l]putu ts[kkel kuna tingimuseks on pandud true
            while (true)
            {
                //n'itab tulemust konsoolis
                Console.WriteLine("i = {0}", i);
                //lisab [he v[rra juurde i muutujale
                i++;
                //kui i on suurem 10-st, siis mine break juurde
                if (i > 10)
                {
                    //l]peta programm 'ra
                    break;
                }
            }
        }
    }
}