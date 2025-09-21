using Evaluator_Core;

Console.WriteLine("Hello, Evaluator");
var infix1 = "144^(1/2)";
var result1 = Logic_Evaluator.Evaluate(infix1);
Console.WriteLine($"{infix1} = {result1}");
var infix2 = "(3,1416+70)/(300^(1/3,2))";
var result2 = Logic_Evaluator.Evaluate(infix2);
Console.WriteLine($"{infix2} = {result2}");