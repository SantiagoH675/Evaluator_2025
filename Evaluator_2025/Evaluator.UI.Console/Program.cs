using Evaluator_Core;

Console.WriteLine("Hello, Evaluator!");
var infix = "1+2";
var result = Logic_Evaluator.Evaluate(infix);
Console.WriteLine($"{infix}= {result}");