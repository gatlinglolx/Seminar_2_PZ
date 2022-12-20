int number = new Random().Next (10,1000);
Console.WriteLine(number);
if (number >= 100)
{
    int thirdNumber = number % 10;
    Console.WriteLine(thirdNumber);
}
else
{
    Console.WriteLine("третьей цифры нет");
}
