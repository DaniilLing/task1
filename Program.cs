Console.WriteLine("введите первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 < num2)
{
    System.Console.WriteLine($"{num1} меньше {num2}");
}
else
{
    System.Console.WriteLine($"{num2} меньше {num1}");
}