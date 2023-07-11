using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Calc
    {

        public void Add(params double[] numbers) 
        {
            //Console.WriteLine("Value of Nuts in Method before Increment \t " + num);
            //num += 5;
            //Console.WriteLine("Value of Num in Method after increment \t " + num);
            //bonus = salary * 0.10;
            double sum = 0;
            foreach(double number in numbers)
            {
                sum += number;
            }
            Console.WriteLine("Total of numbers in \t"+sum);
    }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //int myNum = 15;
            //Calc calc = new Calc();
            //Console.WriteLine("Value of num in Main before Calling increment \t " + myNum);
            //calc.Incr(ref myNum);
            //Console.WriteLine("Value of myNum after calling incremennt in main \t " + myNum);
            //Console.ReadKey();
            Calc calc = new Calc();
            //double salary = 50000;
            //double bonus;
            //calc.Incr(salary, out bonus);
            //Console.WriteLine("Salary is \t" + salary + "\n Bonus is \t" + bonus);
            calc.Add(10, 20, 30);
            calc.Add(10, 20, 30, 40, 50, 60);

            Console.ReadKey();
        }
    }
}
