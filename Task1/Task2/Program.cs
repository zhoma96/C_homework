﻿int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if(b > max)
{
    max = b;
    Console.WriteLine($"max = {max}");
}
else if(c > max)
{
    max = c;
    Console.WriteLine($"max = {max}");
}
