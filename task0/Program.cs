/*
Напишите программу, которая на вход принимает число и выдает его квадрат.
Например:
4 -> 16
-3 -> 9
-7 -> 49
*/
Console.Write("Введи число: ");

int number = Convert.ToInt32(Console.ReadLine());

int result = number * number;

Console.WriteLine(result);
