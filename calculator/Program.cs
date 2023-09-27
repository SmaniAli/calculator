Console.WriteLine("please enter first num");
int firstNum = int.Parse(Console.ReadLine());
Console.WriteLine("please enter the operation");
string operation = Console.ReadLine();
Console.WriteLine("please enter first num");
int secondNum = int.Parse(Console.ReadLine());

int result;
if (operation == "+") result = firstNum + secondNum;
else if (operation == "-") result = firstNum - secondNum;
else if (operation == "*") result = secondNum * firstNum;
else if (operation == "/") result = firstNum / secondNum;
else result = 0;

Console.WriteLine(result);
