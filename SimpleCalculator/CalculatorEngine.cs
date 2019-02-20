using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class CalculatorEngine
    {
        public double Calculate (string Opertation, double FirstNumber, double SecondNumber)
        {
            double result;
        
            switch (Opertation.ToLower())
            {
                case "add":
                case "+":
                    result = FirstNumber + SecondNumber;
                    break;
                case "subtract":
                case "-":
                    result = FirstNumber - SecondNumber;
                    break;
                case "multiply":
                case "*":
                    result = FirstNumber * SecondNumber;
                    break;
                case "divide":
                case "/":
                    result = FirstNumber / SecondNumber;
                    break;
                default:
                    throw new InvalidOperationException("Specified operation is not recognized");
            }
            return result;
        }
    }
}
