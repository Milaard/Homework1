//Напишите программу, которая на вход принимает число (N), а на выход показывает все четные числа от 1 до N
Console.WriteLine("Введите число > 0");
int num = int.Parse(Console.ReadLine());

while(num>2)
{
    if(num % 2 == 0)
    {
        Console.Write( num + "," );
    }    
    num = num - 1;
}
if ( num == 2)
{
    Console.Write(num);
}
else
{
    Console.Write("Нет четных чисел");
}