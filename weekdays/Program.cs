﻿int n = int.Parse(Console.ReadLine());

if ( n < 1 | n > 7)
{
    Console.WriteLine("Ввели неправильное число");
}
if (n == 1)
{
    Console.WriteLine("Понедельник");
}
if (n == 2)
{
    Console.WriteLine("вторник");
}
if (n == 3)
{
    Console.WriteLine("среда");
}
if (n == 4)
{
    Console.WriteLine("четверг");
}
if (n == 5)
{
    Console.WriteLine("пятница");
}
if (n == 6)
{
    Console.WriteLine("суббота");
}
if (n == 7)
{
    Console.WriteLine("воскресенье");
}