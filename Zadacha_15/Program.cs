int Monday = 1;
int Tuesday = 2;
int Wednesday = 3;
int Thursday= 4;
int Friday= 5;
int Saturday = 6;
int Sunday = 7;
int number = new Random().Next (1,8);
Console.WriteLine(number);
if (number == 6 || number == 7)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}
