//Напишите программу, которая на выход принимает число и выдаёт его квадрат

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int square = num * num;
Console.WriteLine($"Квадрат числа {num} равен {square}");
