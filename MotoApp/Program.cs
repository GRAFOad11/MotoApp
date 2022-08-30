using MotoApp;

var stack = new Stack<double>();

stack.Push(item: 4.5);
stack.Push(item: 43);
stack.Push(item: 333.6);

double sum = 0.0;
var stackString = new BasicStack<string>();

stackString.Push(item: "Adrian");
stackString.Push(item: "Ania");
stackString.Push(item: "Kevin");

while (stack.Count > 0)
{
    double item = stack.Pop();
    Console.WriteLine($"Item: {item}");
    sum += item;
}

Console.WriteLine($"Sum: {sum}");

while (stackString.Count > 0)
{
    string item = stackString.Pop();
    Console.WriteLine($"Item: {item}");
    
}

