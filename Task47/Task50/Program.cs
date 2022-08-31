Int32 a, b, m, n;
Console.WriteLine("Введите размеры массива: "); 
var s = Console.ReadLine().Split(" ");
m = Convert.ToInt32(s[0]);
n = Convert.ToInt32(s[1]);
int[,] array = new int[m, n];
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        array [i, j] = Convert.ToInt32(new Random().Next(1,10));  
}
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + "\t  ");
        Console.WriteLine();
}
 
 Console.WriteLine("Введите координаты");
var ss = Console.ReadLine().Split(" ");
a = Convert.ToInt32(ss[0]);
b = Convert.ToInt32(ss[1]);
 if (a>m && b>n)
 Console.WriteLine("Такого числа нет");
 else
 {
 object c = array.GetValue(a,b);
 Console.WriteLine(c);
 }