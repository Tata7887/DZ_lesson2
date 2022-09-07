//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

Console.WriteLine("Введите трехзначное число");
int number = int.Parse(Console.ReadLine());

int div = number / 10;

Console.WriteLine($"Вторая цифра числа {div % 10}");


