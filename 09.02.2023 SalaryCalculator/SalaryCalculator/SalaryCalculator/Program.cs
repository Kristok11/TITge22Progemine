namespace SalaryCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Employee program = new Employee();

            //SalaryCalculation();
        }
    }

    public static class Employee
    {
        public static double SalaryCalculation()
        {
            float brutoIncome = 2000;
            double incomeTax = 0.2;
            
            float taxFreeIncome = 654;

            double deductibleIncome = brutoIncome - taxFreeIncome;
            double taxSum = deductibleIncome * incomeTax;
            double netIncome = brutoIncome - taxSum;

            Console.WriteLine(netIncome);
            return netIncome;
        }
    }
}