﻿// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int  num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine($"Число {num1} больше {num2}");
}
else if (num1 <num2)
{
    Console.WriteLine($"Число {num2} больше {num1}");
}
else
{
    Console.WriteLine($"Число {num1} равно {num2}");
}