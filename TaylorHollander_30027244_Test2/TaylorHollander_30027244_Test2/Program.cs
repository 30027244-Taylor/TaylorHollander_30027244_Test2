using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaylorHollander_30027244_Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Taylor Hollander
            //Payroll application will calculate what each of the staff members will be paid during 2019
           
            //New Salary object instantiated
            Salary s1 = new Salary();
            Console.WriteLine(s1.DisplaySalary());
            Console.WriteLine();
            Console.WriteLine();
            

            //New Wages object instantiated
            Wages w1 = new Wages();

            Console.Write("Please enter the number of hours worked: ");
            //User input saved as NumHours for the Wages object we created
            w1.NumHours = int.Parse(Console.ReadLine());

            Console.WriteLine(w1.DisplayWages());

            Console.ReadLine();
        }
    }

    public class Salary
    {
        private double annualSalary = 80000;
        private double weeklySalary;

        public double AnnualSalary { get { return annualSalary; } set { annualSalary = value; } }
        public double WeeklySalary { get { return weeklySalary; } set { weeklySalary = value; } }

        //Constructor will display annual salary when a Salary object is instantiated
        public Salary()
        {
            Console.WriteLine($"Your annual salary is ${AnnualSalary} per year");
        }

        //Method that will calculate the weekly salary
        public string DisplaySalary()
        {
            WeeklySalary = Math.Round((AnnualSalary / 52), 2);
            return "Your salary per week is $" + Convert.ToString(WeeklySalary);
        }
    }

    public class Wages
    {
        private double hourlyRate = 33.72;
        private int numHours;
        private double weeklyWages;

        public int NumHours { get { return numHours; } set { numHours = value; } }
        public double WeeklyWages { get { return weeklyWages; } set { weeklyWages = value; } }
        public double HourlyRate { get { return hourlyRate; } set { hourlyRate = value; } }

        //Constructor will display this message when a Wages object is instantiated
        public Wages()
        {
            Console.WriteLine("I will calculate your wages...");
        }

        //Method will calculate the weekly wages based on user input (for hours worked that week, from Main method)
        public string DisplayWages()
        {
            WeeklyWages = Math.Round((HourlyRate * NumHours), 2);
            return "Your wage per week is $" + Convert.ToString(WeeklyWages);
        }



    }
}