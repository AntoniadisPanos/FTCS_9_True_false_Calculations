using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTCS_9_True_false_Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true, b = true;
            int c = 1;
            Console.Write("Enter your preffered first number: ");
            int firstnumber = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            Console.Write("Enter your preffered second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Please type '1' for 'True' or '2' for 'False' for the first Boolean: ");
            int TrueOrFalseFirstAnswer = Convert.ToInt32(Console.ReadLine());

            while (TrueOrFalseFirstAnswer != 1 && TrueOrFalseFirstAnswer != 2)
            {
                Console.Clear();
                Console.Write("Enter 1 or 2 for the first Boolean: ");
                TrueOrFalseFirstAnswer = Convert.ToInt32(Console.ReadLine());
            }

            if (TrueOrFalseFirstAnswer == 1)
                a = true;
            else
                a = false;

            Console.Clear();
            Console.WriteLine("Please type '1' for 'True' or '2' for 'False' for the second Boolean: ");
            int TrueOrFalseSecondAnswer = Convert.ToInt32(Console.ReadLine());

            while (TrueOrFalseSecondAnswer != 1 && TrueOrFalseSecondAnswer != 2)
            {
                Console.Clear();
                Console.Write("Enter 1 or 2 for the second Boolean: ");
                TrueOrFalseSecondAnswer = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(Calculations(a, b, c, firstnumber, secondNumber, TrueOrFalseSecondAnswer));
        }


        private static string Calculations(bool a, bool b, int c, int firstnumber, int secondNumber, int TrueOrFalseSecondAnswer)
        {
            if (TrueOrFalseSecondAnswer == 1)
                b = true;
            else b = false;
            Console.Clear();
            if (a == false && b == false)
            {
                c = firstnumber + secondNumber;
                return $" The result is: {c}";
            }
            else if (a == false && b == false)
            {
                c = firstnumber - secondNumber;
                return $"The result is: {c}";
            }
            else if (a == false && firstnumber > 5)
            {
                c = firstnumber * secondNumber;
                return $"The result is: {c}";
            }
            else if (b == true && firstnumber + secondNumber > 45 && firstnumber % secondNumber == 0)
            {
                return "This is the ultimate result";
            }
            else
            {
                return "Try something else";
            }









        }





    }
}
