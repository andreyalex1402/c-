Console.Write("Введи N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write($"N={N}, M={M}");
int a = 0;
if (M>N)
for (int i = N; i <= M; i++)
    a = a + i;
else
    for (int i = M; i <= N; i++)
        a = a + i;
Console.Write($" -> {a}");        