// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
Console.Clear();
Console.WriteLine("Введите пятизначное число n: ");
int n = int.Parse(Console.ReadLine());
int a = n / 10;
int b = n - a*10;
int c = a / 1000;
int d = a % 10;
int f = (a % 1000)/100;
if (b == c && d == f)
{
    Console.WriteLine($"Число {n} является палиндромом");
}
else
{
    Console.WriteLine($"Число {n} не является палиндромом");
}