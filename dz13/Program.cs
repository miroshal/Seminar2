// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a < 100)
{
    Console.WriteLine("Третьей цифры нет. ");
}
else
{
    while (a > 999)
    {
        a = a / 10;
    }
    a = a % 10;
    Console.WriteLine(a);
}