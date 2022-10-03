Console.WriteLine("Hello, User! Введите первое число");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int num2 = int.Parse(Console.ReadLine()!);
if (num1>num2)
{
   Console.WriteLine($"{num1} максимальное"); 
   Console.WriteLine($"{num2} минимальное");
}
else
{
   Console.WriteLine($"{num2} максимальное");  
   Console.WriteLine($"{num1} минимальное");
}
