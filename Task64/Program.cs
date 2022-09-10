Console.Write("Введи N: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = N ; i >=1 ; i--)
{
    if (i>1)
    Console.Write($" {i},");
    else
    Console.Write($" {i}");
}