using System;
using System.Collections.Generic;
using System.Text;

namespace App2_Calc.Impl
{
    public interface IICalculation
    {
        double Sum(double num1, double num2);
        double Subtract(double num1, double num2);
        double Multiply(double num1, double num2);
        double Divide(double num1, double num2);
    }
}
