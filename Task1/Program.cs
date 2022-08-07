//Напишите програму, которая на вход принимает два числа и проверяет, являится первое число квадратом второго

Console.Write("Введите превое целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2*num2)
{
    Console.WriteLine($"Число {num1} является квадратом {num2}");
}
else
{
    Console.WriteLine($"Число {num1} не являтся квадратом {num2}");
}