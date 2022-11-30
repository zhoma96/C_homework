Console.WriteLine("Enter day number");
int num = Convert.ToInt32(Console.ReadLine());
int monday = 1;
int tuesday = 2;
int wednesday = 3;
int thursday = 4;
int friday = 5;
int saturday = 6;
int sunday = 7;
if(num == saturday || num == sunday)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No, it is not weekend");
}