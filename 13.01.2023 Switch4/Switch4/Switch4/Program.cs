namespace Switch4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string topic;
            string category;

            topic = "Inheritane";

            switch (topic)
            {
                case "Intro to C#":
                case "Variables":
                case "Data Types":

                    category = "Basic";
                    break;

                case "Loops":
                case "if Statement":
                case "Jump Statments":

                    category = "Control Flow";
                    break;

                case "Class & Object":
                case "Inheritance":
                case "Constructor":

                    category = "OOPS Concept";
                    break;

                default:
                    category= "Unknown";
                    break;
            }

            Console.WriteLine("category is " + category);
        }
    }
}