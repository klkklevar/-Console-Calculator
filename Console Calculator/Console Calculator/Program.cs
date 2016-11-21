using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            char again = 'y';//char repersent a unicode character value type (literal character) = 'y'
            while (again == 'y')//while/while loop represent a statment or block with condition: == 'y'
            {
                double num1;
                double num2;
                double total;
                char oper = '+';

                Console.WriteLine("Enter first number: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter operator");
                oper = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("Enter second number: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                if (oper == '+')
                {
                    total = num1 + num2;
                    Console.WriteLine("Your answer is " + total);

                }
                else if (oper == '-')
                {
                    total = num1 - num2;
                    Console.WriteLine("Your answer is " + total);
                }
                else
                {
                    Console.WriteLine("Invalid Operator");
                }
            }

        }
    }
}
        
   

