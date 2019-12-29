using System;
using System.Collections.Generic;
using System.Text;
using App2_Calc.Impl;

namespace App2_Calc.Model
{
    public class Calculation : IICalculation
    {
        public double Sum(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Divide(double num1, double num2)
        {
            try
            {
                return num1 / num2;
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("\n\t\tError : " + e.Message + "\n\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("\n\t\tError : " + e.Message + "\n\n");
            }
            return 0.0;            
        }       
    }
}
