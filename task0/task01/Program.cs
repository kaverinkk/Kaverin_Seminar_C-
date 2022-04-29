/* Напишите программу, которая принимает на вх 2 числа и проверяет, является ли 1 число квадратом 2.
Например: 
a = 5; b = 25 -> да;
a = 7; b = 20 -> нет
*/

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

if (a * a == b)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}    


