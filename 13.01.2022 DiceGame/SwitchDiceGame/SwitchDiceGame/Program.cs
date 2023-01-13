namespace SwitchDiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("T'ringute veeretamine");

            //selle muutuja all on nimekiri objekte
            var values = new List<object>();

            for (int ctr = 0; ctr <= 4; ctr++)
            {
                if (ctr == 2)
                {
                    values.Add(DiceLibrary.Roll2());
                }
                else if (ctr == 4)
                {
                    values.Add(DiceLibrary.Pass());
                }
                else
                {
                    values.Add(DiceLibrary.Roll());
                }
                Console.WriteLine($"Veeretamise nr on {values.Count} " +
                    $" ja summa t'ringutel {DiceLibrary.DiceSum(values)}");
            }
        }
    }

    public static class DiceLibrary
    {
        static Random rnd = new Random();

        //Veereta ainult [hte t'ringut
        public static int Roll()
        {
            return rnd.Next(1, 7);
        }

        //veereta kaks t'ringut
        public static List<object> Roll2()
        {
            var rolls = new List<object>();
            rolls.Add(Roll());
            rolls.Add(Roll());
            return rolls;
        }

        public static int DiceSum(IEnumerable<object> values)
        {
            var sum = 0;
            foreach (var item in values)
            {
                switch (item)
                {
                    //kui tuleb 0
                    case 0:
                        break; 
                    //kui v''rtus on [ks
                    case int val:
                        sum += val;
                        break;

                    //mitte-t[hi kollektsioon v]i nimekiri
                    case IEnumerable<object> subList when subList.Any():
                        sum += DiceSum(subList);
                        break;

                    //t[hi nimekiri
                    case IEnumerable<object> subList:
                        break;

                    //NULL (kui t[hi) viide
                    case null:
                        break;

                    //v''rtus, mis ei ole int ega ka nimekiri
                    default:
                        throw new InvalidOperationException("tundmatu andmet[[p");
                }
            }

            return sum;
        }

        public static object Pass()
        {
            if (rnd.Next(0, 2) == 0)
            {
                return null;
            }
            else
            {
                return new List<object>();
            }
        }
    }
}