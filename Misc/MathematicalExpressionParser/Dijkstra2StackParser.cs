using System.Collections.Generic;

namespace Dsna.Misc.MathematicalExpressionParser
{
    public class Dijkstra2StackParser : IParseMathematicalExpression
    {
        public double Parse(string expression)
        {
            Stack<char> operatorStack = new Stack<char>();
            Stack<double> operandStack = new Stack<double>();

            foreach (char e in expression)
            {
                switch (e)
                {
                    case '(':
                    case ' ':
                        continue;

                    case '+':
                    case '-':
                    case '*':
                    case '/':
                        operatorStack.Push(e);
                        break;
                    case ')':
                        char op = operatorStack.Pop();

                        double value1 = operandStack.Pop();
                        double value2 = operandStack.Pop();
                        
                        operandStack.Push(this.Evaluate(op, value1, value2));
                        break;
                    default:
                        operandStack.Push(double.Parse(e.ToString()));
                        break;
                }
            }

            while (operatorStack.Count != 0)
            {
                char op = operatorStack.Pop();

                double value1 = operandStack.Pop();
                double value2 = operandStack.Pop();

                operandStack.Push(this.Evaluate(op, value1, value2));
            }

            return operandStack.Pop();
        }

        private double Evaluate(char op, double value1, double value2)
        {
            double result = 0.00d;

            switch (op)
            {
                case '+':
                    result = value2 + value1;
                    break;
                case '-':
                    result = value2 - value1;
                    break;
                case '*':
                    result = value2 * value1;
                    break;
                case '/':
                    result = value2 / value1;
                    break;
            }

            return result;
        }
    }
}
