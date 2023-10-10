Console.WriteLine("Enter a number  ");
double num=Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter an operator");
string op=Console.ReadLine();

Console.WriteLine("Enter the second number");
double num2=Convert.ToDouble(Console.ReadLine());

if (op == "+")
{ Console.WriteLine(num + num2); }

else if (op== "-")
{ Console.WriteLine(num - num2); }
else if (op== "*")
{ Console.WriteLine(num*num2); }
else if (op== "/")
{ Console.WriteLine(num/num2); }
else
{ Console.WriteLine("Not an operator"); }

Console.Read();


