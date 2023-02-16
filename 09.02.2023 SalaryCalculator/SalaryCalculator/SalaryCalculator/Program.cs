namespace SalaryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjuta brutopalk: ");
            double brutoSalary = Convert.ToDouble(Console.ReadLine());
            double netIncome = 0;

            if (brutoSalary <= 1200)
            {
                netIncome = Employee.SalaryCalculationLess1200(brutoSalary, netIncome);
            }
            else if (brutoSalary >= 1200.01 && brutoSalary <= 2100)
            {
                netIncome = Employee.SalarycalculationFrom1200To2100(brutoSalary, netIncome);
            }
            else if (brutoSalary >= 2100.01)
            {
                netIncome = Employee.SalaryCalulationIsAbove2100(brutoSalary, netIncome);
            }
            else
            {
                Console.WriteLine("ERROR, väga imelik palk on sul");
            }

            //siia tulekisd vastused e Console.WriteLine(vastus);
            Console.WriteLine("Neto sissetulek on " + netIncome);
        }
    }

    public static class Employee
    {
        public static double SalaryCalculationLess1200(double brutoSalary, double netIncome)
        {
            double incomeTax = 0.2;
            float taxFreeIncome = 654;

            double pensionFond = brutoSalary * 0.02;
            double unEmpTax = brutoSalary * 0.016;
            double incomeTaxSum = incomeTax * (brutoSalary - (taxFreeIncome + pensionFond + unEmpTax));
            netIncome = brutoSalary - (pensionFond + unEmpTax + incomeTaxSum);

            return netIncome;
        }

        public static double SalarycalculationFrom1200To2100(double brutoSalary, double netIncome)
        {
            double incomeTax = 0.2;
            double taxFreeIncome = 654 - 0.72667 * (brutoSalary - 1200);

            double pensionFond = brutoSalary * 0.02;
            double unEmpTax = brutoSalary * 0.016;
            double incomeTaxSum = incomeTax * (brutoSalary - (taxFreeIncome + pensionFond + unEmpTax));
            netIncome = brutoSalary - (pensionFond + unEmpTax + incomeTaxSum);

            return netIncome;
        }

        public static double SalaryCalulationIsAbove2100(double brutoSalary, double netIncome)
        {
            double incomeTax = 0.2;
            
            double pensionFond = brutoSalary * 0.02;
            double unEmpTax = brutoSalary * 0.016;
            double incomeTaxSum = incomeTax * (brutoSalary - (pensionFond + unEmpTax));
            netIncome = brutoSalary - (pensionFond + unEmpTax + incomeTaxSum);

            return netIncome;
        }
    }
}