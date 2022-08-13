/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Решить без использования строк.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write($"{number}");
if (number < 100) System.Console.WriteLine("Третьего числа нет");
else 
{
     while (number > 1000)
     {
        number = number /10 ;
     }
    number = number %10;
    Console.WriteLine($" => {number}");
}