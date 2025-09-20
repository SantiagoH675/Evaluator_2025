using System.Data;

namespace Evaluator_Core;

public class Logic_Evaluator
{
    public static double Evaluate(string infix)
    {
        var postfix = InfixToPostFix(infix);

        return Calculate(postfix);
    }

    private static string InfixToPostFix(string infix)
    {
        var stack = new Stack<char>();
        var postfix = string.Empty;

        return postfix;
    }

    private int PriorityInfix(char op) => op switch
    {
        '^' => 4,
        '*' or '/' or '%' => 2,
        '-' or '+' => 1,
        '(' => 5,
        _ => throw new Exception("Invalid espression"),
    };

    private int PriorityStack(char op) => op switch
    {
        '^' => 3,
        '*' or '/' or '%' => 2,
        '-' or '+' => 1,
        '(' => 0,
        _ => throw new Exception("Invalid espression"),
    };

    private static double Calculate(string postfix)
    {
        throw new NotImplementedException();
    }
}