Console.WriteLine("Enter number:");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(num);
if(num < 100)
{
    Console.WriteLine("No third digit");
}
else
{
    string numStr = Convert.ToString(num);
    Console.WriteLine(numStr[2]);
}