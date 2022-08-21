/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2*/
double[] array = new double[4];
Random myRandom = new Random();
int a = 0;
for (int i = 0; i < 4; i++) 
    { 
        array[i] = myRandom.NextDouble(-99, 100);
        Console.Write($"{array[i]} ");
        a++;
    }