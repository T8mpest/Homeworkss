using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter the task: ");
                    string input = Console.ReadLine();

                    double result = CalculateExpression(input);
                    Console.WriteLine("result: " + result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }

                Console.WriteLine("Continue? (Yes/No)");
                string continueInput = Console.ReadLine();
                if (continueInput?.ToLower() != "yes")
                    break;
            }
        }

        static double CalculateExpression(string expression)
        {
            expression = expression.Replace(" ", ""); 

            
            return CalculateSubExpression(expression);
        }

        static double CalculateSubExpression(string expression)
        {
            if (double.TryParse(expression, out double number)) 
                return number;

            int startIndex = 0;
            int endIndex = expression.Length - 1;

           
            while (startIndex < expression.Length && expression[startIndex] != '(')
                startIndex++;

            while (endIndex >= 0 && expression[endIndex] != ')')
                endIndex--;

            
            if (startIndex < expression.Length && endIndex >= 0 && startIndex < endIndex)
            {
                string subExpression = expression.Substring(startIndex + 1, endIndex - startIndex - 1);
                double subResult = CalculateSubExpression(subExpression);
                expression = expression.Remove(startIndex, endIndex - startIndex + 1).Insert(startIndex, subResult.ToString());
                return CalculateSubExpression(expression); 
            }

            
            string[] addSubParts = expression.Split(new char[] { '+', '-' }, StringSplitOptions.RemoveEmptyEntries);
            double result = CalculateMultiplicationDivision(addSubParts[0]); 

            
            for (int i = 1; i < addSubParts.Length; i++)
            {
                char operation = expression[expression.IndexOf(addSubParts[i]) - 1];
                double operand = CalculateMultiplicationDivision(addSubParts[i]);

                if (operation == '+')
                    result += operand;
                else
                    result -= operand;
            }

            return result;
        }

        static double CalculateMultiplicationDivision(string expression)
        {
           
            string[] mulDivParts = expression.Split(new char[] { '*', '/' }, StringSplitOptions.RemoveEmptyEntries);
            double result = double.Parse(mulDivParts[0]); 

            
            for (int i = 1; i < mulDivParts.Length; i++)
            {
                char operation = expression[expression.IndexOf(mulDivParts[i]) - 1];
                double operand = double.Parse(mulDivParts[i]);

                if (operation == '*')
                    result *= operand;
                else
                {
                    if (operand == 0)
                        throw new DivideByZeroException("We cant divide on zero.");
                    result /= operand;
                }
            }

            return result;
        }
    }
}
    
