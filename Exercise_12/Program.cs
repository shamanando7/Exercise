// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21


Console.WriteLine("Введите координатy A: ");
var AString = Console.ReadLine();
double A = double.Parse(AString);

Console.WriteLine("Введите координату B: ");
var BString = Console.ReadLine();
double B = double.Parse(BString);

double sqrt = Math.Sqrt(A + B);

Console.WriteLine("Расстояние между двумя точками " + sqrt.ToString("N2")); // округление




 // мое творение. 