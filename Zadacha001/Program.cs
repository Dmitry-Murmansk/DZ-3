Console.WriteLine("введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
int dig1 = number / 10000;
int dig2 = (number / 1000) % 10;
int dig4 = (number / 10) % 10;
int dig5 = number % 10;
if (number < 9999 || number > 99999)
{
    Console.Write("Число не пятизначное");
}
else
{
    if (dig1 == dig5 && dig2 == dig4)
    {
        Console.Write("Да, число - полиндром");
    }
    else
    {
        Console.Write("Нет, число - не полиндром");
    }
}