Console.WriteLine("Программа котрая находит расстояние между двумя точками в 3D простанстве");
Console.WriteLine("Введите координаты точек");

Console.WriteLine("Координаты первой точки. X =");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y = ");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Z = ");
int Z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Координаты второй точки. X =");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y = ");
int Y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Z = ");
int Z2 = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow (X2-X1, 2) + Math.Pow (Y2-Y1, 2) + Math.Pow (Z2-Z1, 2));

Console.WriteLine($"Расстояние = {distance}");
