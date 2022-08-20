/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень числа: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int i = num;
int a = 1;
if (num1 > 0)
{
    while (a < num1)
    {
        num = num * i ;
        a++;
    }
    Console.WriteLine($"{i}, {num1} -> {num}");
}
else if (num1 == 0)
{
 Console.WriteLine($"{i}, {num1} -> 1");
}
