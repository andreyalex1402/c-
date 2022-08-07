// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
if (num1 >= num2 & num1 >= num3) System.Console.WriteLine($"Число {num1} самое большое");
else if (num2 >= num1 & num2 >= num3) System.Console.WriteLine($"Число {num2} самое большое");
else if (num3 >= num2 & num3 >= num1) System.Console.WriteLine($"Число {num3} самое большое");