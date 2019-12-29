using System;
using App2_Calc.Model;

namespace App2_Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation calc = new Calculation();

            Console.WriteLine();
            try
            {
                Console.Write("\t\tEnter a number : ");
                double num1 = double.Parse(Console.ReadLine());
                Console.Write("\t\tEnter another number : ");
                double num2 = double.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.Write("\t\tSum (S), Subtract (B), Multiply (M) ou Divide (D)? Enter the letters : ");
                char letter = char.Parse(Console.ReadLine());
                Console.WriteLine();

                if (letter == 'S' || letter == 's')
                {
                    double sum = calc.Sum(num1, num2);
                    Console.WriteLine("\t\tSum = " + sum.ToString());
                }
                else if (letter == 'B' || letter == 'b')
                {
                    double sub = calc.Subtract(num1, num2);
                    Console.WriteLine("\t\tSubtract = " + sub.ToString());
                }
                else if (letter == 'M' || letter == 'm')
                {
                    double mult = calc.Multiply(num1, num2);
                    Console.WriteLine("\t\tMultiply = " + mult.ToString());
                }
                else if (letter == 'D' || letter == 'd')
                {
                    if (num1 == 0 || num2 == 0)
                    {
                        Console.WriteLine("\n\t\tThere is no division by zero.");
                        Console.WriteLine();
                    }
                    else
                    {
                        double div = calc.Divide(num1, num2);
                        Console.WriteLine("\t\tDivide = " + div.ToString());
                    }
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("\n\t\tError : " + e.Message + "\n\n");
            } 
            catch(Exception e)
            {
                Console.WriteLine("\n\t\tError : " + e.Message + "\n\n");
            }
        }
    }
}
