using System.Linq.Expressions;

namespace RPN
{
    public class RPNCalc
    {
        static void Main()
        {
            //create a calculator that evaluates expressions in RPN
            // 5*2 5 2 *
            //push 5 onto stack, push 2 onto stack, encounter *, pop 5 and 2, compute 5 * 2 = 10, push 10 onto stack
        }
        public static double Evaluation(string Expression)
        {
            var stack = new Stack<double>();

            foreach (var token in Expression.Split(' '))
            {
                double result;
                if (double.TryParse(token, out result))
                {
                    stack.Push(result);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return 0;
                    }
                    double rightOperant = stack.Pop();
                    double leftOperant = stack.Pop();
                    switch (token)
                    {
                        case "+":
                            stack.Push(leftOperant + rightOperant);
                            break;
                        case "-":
                            stack.Push(leftOperant - rightOperant);
                            break;
                        case "*":
                            stack.Push(leftOperant * rightOperant);
                            break;
                        case "/":
                            stack.Push(leftOperant / rightOperant);
                            break;
                        default:
                            throw new Exception("Invalid operator");
                    }
                }
            }
            return stack.Pop();
        }
    }
}