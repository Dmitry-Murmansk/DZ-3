Console.WriteLine("Введите число N");
double num = Convert.ToInt32(Console.ReadLine());
double numCube = Math.Pow(num, 3);
double count = 1;
double Cube = 0;
while (count < num)
{
    Cube = Math.Pow(count, 3);
    Console.Write(Cube + ",");
    count++;
}
Console.Write(numCube);
//Задача 23: Напишите программу, 
//которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.