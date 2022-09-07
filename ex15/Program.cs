// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите цифру дня недели");
int number = int.Parse(Console.ReadLine());

if (number == 6 || number == 7)

Console.WriteLine("да");

else

Console.WriteLine("нет");