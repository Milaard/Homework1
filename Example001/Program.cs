// Напишите программу, которая на вход принимает два числа  и выдает, какое число большее, а какое меньшее
System.Console.WriteLine("Введите два числа: ");
string num1 = Console.ReadLine();
string num2 = Console.ReadLine();
if(int.Parse(num1)>int.Parse(num2))
{
   Console.WriteLine($"Максимальное число: {num1}, минимальное число: {num2}");
}   
else 
{
    Console.WriteLine($"Максимальное число: {num2}, минимальное число: {num1}");
}   



