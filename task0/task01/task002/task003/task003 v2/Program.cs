/* Напишите программу, кот на входе принимает число n, а на выходе
показывает все целые числа в промеж от -n до n*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
for (int i = - number; i <= number; i++)
{
    Console.Write(i);
    if (i != number)
    {
        Console.Write(", ");
    }
    
}
 