
Console.Write("Введите номер дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num <= 5 & num > 0) System.Console.WriteLine($"{num} являтся будним днём");
else if (num <= 7 & num > 5 & num < 8) System.Console.WriteLine($"{num} являтся выходным днём");
else System.Console.WriteLine("Чесло не входит в диапозон от 1 до 7");
