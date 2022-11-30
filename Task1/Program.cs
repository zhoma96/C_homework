Console.Write("Enter number between 100 and 999:");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(num);
if(num < 1000 && num > 0)
{
    int midNum = (num % 100) / 10;
    Console.WriteLine(midNum);
}
else
{
    Console.WriteLine("Error. Please enter only numbers between 100 and 999");
}