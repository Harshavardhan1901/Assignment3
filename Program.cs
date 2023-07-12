using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //P-1 TryParse method to convert string to int
            string intString = "123456";
            int intValue;
            if (int.TryParse(intString, out intValue))
            {
                Console.WriteLine("Converted integer value is: " + intValue);
            }
            else
            {
                Console.WriteLine("!!!The String is not a valid integer!!!");
            }
            Console.ReadKey();

            //P-1 Convert method to convert string to double
            string doubleString = "9876.6789";
            try
            {
                double doubleValue = Convert.ToDouble(doubleString);
                Console.WriteLine("Convert successful. Converted double value is: " + doubleValue);
            }
            catch (FormatException)
            {
                Console.WriteLine("Convert failed. Invalid input format.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Convert failed. Input value is too large or too small.");
            }
            Console.ReadKey();

            //P-1 Parse method to convert string to decimal
            string decimalString = "10.01";
            try
            {
                decimal decimalValue = decimal.Parse(decimalString);
                Console.WriteLine("Parse successful. Converted decimal value: " + decimalValue);
            }
            catch (FormatException)
            {
                Console.WriteLine("Parse failed. Invalid input format.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Parse failed. Input value is too large or too small.");
            }
            Console.ReadKey();

            //P-2 Convert a string to an integer using the TryParse method
            Console.WriteLine("Enter a number: ");
            string input = Console.ReadLine();
            int number;
            if (int.TryParse(input, out number))
            {
                int result = number * 5;
                Console.WriteLine($"The result is: {result}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            Console.ReadLine();

            //P-2 Convert a string to a DateTime object using the Convert method
            Console.WriteLine("Enter a date (MM/dd/yyyy): ");
            string dateInput = Console.ReadLine();
            try
            {
                DateTime date = Convert.ToDateTime(dateInput);
                DateTime newDate = date.AddMonths(-1);
                Console.WriteLine($"One month ago was: {newDate.ToShortDateString()}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid date in the format MM/dd/yyyy.");
            }
            Console.ReadLine();

            //P-2 Convert a string to a TimeSpan object using Parse method
            Console.WriteLine("Enter a time (hh:mm:ss): ");
            string timeInput = Console.ReadLine();
            try
            {
                TimeSpan time = TimeSpan.Parse(timeInput);
                TimeSpan newTime = time.Add(new TimeSpan(2, 0, 0));
                Console.WriteLine($"Two hours later will be: {newTime.ToString()}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid time in the format hh:mm:ss.");
            }
            Console.ReadLine();

        }
    }
}
