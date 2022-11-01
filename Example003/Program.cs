//Напишите программу, которая на вход принимает число и выдает, является ли число четным(делится ли оно на два без остатка )
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
int result = num % 2;
if(result == 0)
{
    Console.WriteLine("Да, число четное");
}
else
{
    Console.WriteLine("Нет, число нечетное");
}