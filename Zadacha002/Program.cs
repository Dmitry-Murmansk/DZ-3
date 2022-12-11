Console.Write("введите координату точки A по x: ");
double aX = Convert.ToInt32(Console.ReadLine());
Console.Write("введите координату точки A по y: ");
double aY = Convert.ToInt32(Console.ReadLine());
Console.Write("введите координату точки A по z: ");
double aZ = Convert.ToInt32(Console.ReadLine());
Console.Write("введите координату точки B по x: ");
double bX = Convert.ToInt32(Console.ReadLine());
Console.Write("введите координату точки B по y: ");
double bY = Convert.ToInt32(Console.ReadLine());
Console.Write("введите координату точки B по z: ");
double bZ = Convert.ToInt32(Console.ReadLine());
double quadroX = Coord(bX, aX);
double quadroY = Coord(bY, aY);
double quadroZ = Coord(bZ, aZ);
double result = Math.Sqrt(quadroX + quadroY + quadroZ);
double Coord(double a, double b)
{
    return Math.Pow((b - a), 2);
}
Console.WriteLine($"расстояние между точками = {result}");
//Напишите программу, которая принимает на вход координаты двух точек и находит 
//расстояние между ними в 3D пространстве.
//