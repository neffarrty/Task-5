using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yearNow, monthNow, dayNow, birthYear, birthMonth, birthDay;

            Console.Write("Enter your birth year: ");
            birthYear = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your birth month: ");
            birthMonth = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your birth day: ");
            birthDay = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a present year: ");
            yearNow = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a present month: ");
            monthNow = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a present day: ");
            dayNow = Convert.ToInt32(Console.ReadLine());

            var sumOfpastDays = birthYear * 365 + birthMonth * 30 + birthDay;
            var sumOfpresentDays = yearNow * 365 + monthNow * 30 + dayNow;

            var spentDays = sumOfpresentDays - sumOfpastDays;
            Console.WriteLine($"You've been living for {spentDays} days");
            Console.ReadKey();
            

        }
    }
}
