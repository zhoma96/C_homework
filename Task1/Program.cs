int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int max = 0;
if(a > b)
{
    max = a;
    Console.WriteLine($"max = {max}");
}
else if(a < b)
{
    max = b;
    Console.WriteLine($"max = {max}");
}
else
{
    Console.WriteLine("Equal");
}