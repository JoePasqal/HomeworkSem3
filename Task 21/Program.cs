// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("введи x первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введи У первой точки");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введи z первой точки");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введи х второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введи У второй точки");                     //Math.Sqrt(x)   - корень 
int y2 = Convert.ToInt32(Console.ReadLine());                  //Math.Pow(x, 2) - квадрат
Console.WriteLine("введи z второй точки");
int z2 = Convert.ToInt32(Console.ReadLine());

double skobX = Math.Pow(x1 - x2, 2);
double skobY = Math.Pow(y1 - y2, 2);
double skobZ = Math.Pow(z1 - z2, 2);
double result = Math.Sqrt(skobX + skobY + skobZ);

Console.WriteLine($"{result:f2}");         //f2 - ф-это округение, 2 -округление до скольки знаков ХД   , двоеточие-значит будемс писать