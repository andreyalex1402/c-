/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях (индексах).
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/
int[] array = new int[4];
Random myRandom = new Random();
int a = 0;
for (int i = 0; i < 4; i++) 
    { 
        array[i] = myRandom.Next(-99, 100);
        Console.Write($"{array[i]} ");
        if (i !=0 & i%2 !=0)
        {
            a = a + array[i]; 
        }
    }    
Console.WriteLine($"->{a}");