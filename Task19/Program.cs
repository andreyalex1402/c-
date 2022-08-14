/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/
Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
string numString = num.ToString(); 
string rev = string.Concat(numString.Reverse());
Console.WriteLine(numString == rev ? "да" : "нет");