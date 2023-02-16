namespace ValueTuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Value Tuple");

            ValueTuple<int, string, string> person1 = (1, "Jaan", "Tallinn");
            Console.WriteLine(person1.Item1);
            Console.WriteLine(person1.Item2);
            Console.WriteLine(person1.Item3);
            Console.WriteLine("---------------------------------------------");
            (int, string, string) person2 = (1, "Vana", "Juurikas");
            Console.WriteLine(person2.Item1);
            Console.WriteLine(person2.Item2);
            Console.WriteLine(person2.Item3);
            Console.WriteLine("---------------------------------------------");

            (int id, string firstName, string lastName) person = (1, "Heli", "Kopter");
            Console.WriteLine(person.id);
            Console.WriteLine(person.firstName);
            Console.WriteLine(person.lastName);
            Console.WriteLine("---------------------------------------------");

            (int id1, string firstName2, string lastName3) person3 = (PersonId: 1, FName: "Tagu", LName: "Ots");
            Console.WriteLine(person3.id1);
            Console.WriteLine(person3.firstName2);
            Console.WriteLine(person3.lastName3);
            Console.WriteLine("---------------------------------------------");

            (string, string, int) person4 = (LName: "Ots", FName: "Tagu", PersonId: 1);
            Console.WriteLine(person4.Item1);
            Console.WriteLine(person4.Item2);
            Console.WriteLine(person4.Item3);

            Console.WriteLine("---------------------------------------------");
            var result = GetPerson();
            Console.WriteLine("{0}, {1}, {2}", result.Item1, result.Item2, result.Item3);

            Console.WriteLine("---------------------------------------------");
            var result1 = GetPerson2();
            Console.WriteLine("{0}, {1}, {2}", result1.id, result1.firstName, result1.lastName);
        }
        // ValueType return tüübina
        static (int, string, string) GetPerson()
        {
            return (1, "Astro", "Naut");
        }

        static (int id, string firstName, string lastName) GetPerson2()
        {
            return (id: 1, firstName: "Peeter", lastName: "Võsa");
        }
    }
}