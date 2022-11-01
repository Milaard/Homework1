// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.

System.Console.WriteLine("Введите три числа: ");
string num1 = Console.ReadLine();
string num2 = Console.ReadLine();
string num3 = Console.ReadLine();
if(int.Parse(num1)>int.Parse(num2))
{
    if(int.Parse(num1)>int.Parse(num3))
    {
        Console.WriteLine($"Максимальное число: {num1}");
    }
    else
    {
        Console.WriteLine($"Максимальное число: {num3}");
    }
}   
else 
{
    if(int.Parse(num2)>int.Parse(num3))
    {
        Console.WriteLine($"Максимальное число: {num2}");

    }
    else
    {
        Console.WriteLine($"Максимальное число: {num3}");
    }
}   
