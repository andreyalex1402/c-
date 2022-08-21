/* Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

int[] array = new int[4];
Random myRandom = new Random();
int a = 0;
for (int i = 0; i < 4; i++) 
    { 
        array[i] = myRandom.Next(100, 1000);
        Console.Write($"{array[i]} ");
        if (array[i]%2 ==0)
        {
            a++;
        }
    }
Console.WriteLine($"-> {a}");