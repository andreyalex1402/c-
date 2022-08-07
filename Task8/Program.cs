// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 0;
while (i+1 < num)
{
    i = i+2;
    Console.Write($"{i} ");
}
