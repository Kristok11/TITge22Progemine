namespace Switch3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta vokaal e t'ish''lik");

            char vowel = Convert.ToChar(Console.ReadLine());

            switch (vowel)
            {
                case 'a':
                    Console.WriteLine("See on a");
                    break;
                case 'e':
                    Console.WriteLine("See on e");
                    break;
                case 'i':
                    Console.WriteLine("See on i");
                    break;
                case 'o':
                    Console.WriteLine("See on o");
                    break;
                default:
                    Console.WriteLine("Ei ole vokaal või seda vokaali ei ole pandud case alla");
                    break;
            }
        }
    }
}