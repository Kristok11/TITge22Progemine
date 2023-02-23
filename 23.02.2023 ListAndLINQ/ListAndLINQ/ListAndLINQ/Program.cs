namespace ListAndLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List and LINQ");

            IList<Person> person = new List<Person>()
            {
                new Person() {Id = 1, Name = "Juku", Age = 10},
                new Person() {Id = 2, Name = "Juhan", Age = 11},
                new Person() {Id = 3, Name = "Maali", Age = 9},
                new Person() {Id = 4, Name = "Aksel", Age = 10},
            };

            var persons = from s in person
                          select new
                          {
                              Id = s.Id,
                              Name = s.Name,
                              Age = s.Age
                          };

            foreach (var per in persons)
            {
                Console.WriteLine("Id on " + per.Id + " ja nimi on " 
                    + per.Name);
            }

            Console.WriteLine("LINQ SELECT e teine variant teha LINQ päring");

            var result = person
                //.Where(p => p.Id == 1) //kui tahan ainult Id 1 isikut saada
                //.Where(y => y.Id == 1 || y.Age == 9) n'en ainult Id 1-ga isikut
                //ja isikut, kellel on vanus 9 a
                //.OrderBy(y => y.Name) //j'rjestab isikud nime järgi ära
                .Select(x => new
                {
                    Name = x.Name,
                    Age = x.Age,
                    Id = x.Id
                });


            foreach (var per in result)
            {
                Console.WriteLine("Id on " + per.Id + " ja nimi on "
                    + per.Name);
            }

            Console.WriteLine("kasutame GroupBy-d sorteerimiseks");

            var groupBy = person
                .GroupBy(x => x.Age);
            //kuvab gruppide kaupa ja antud juhul paneb vanused gruppidese
            // e tulemuseks on kolm rida andmeid kuna kaks isikut on 9 a

            foreach (var item in groupBy)
            {
                Console.WriteLine("Vanuse grupp on: {0}", item.Key);
            }

        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}