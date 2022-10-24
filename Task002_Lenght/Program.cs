// Задача 2
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int Prompt(string msg)
{
     System.Console.Write(msg);
     int number = Convert.ToInt32(Console.ReadLine());
     return number;
}
System.Console.WriteLine("Введите координаты первой точки");
int x1 = Prompt("x1: ");
int y1 = Prompt("y1: ");
int z1 = Prompt("z1: ");
System.Console.WriteLine("Введите координаты первой точки");
int x2 = Prompt("x2: ");
int y2 = Prompt("y2: ");
int z2 = Prompt("z2: ");
int x = x1 - x2;
int y = y1 - y2;
int z = z1 - z2;
   double Lenght = Math.Sqrt(x * x + y * y + z * z);  
     
System.Console.WriteLine($"Расстояние между точками равно {Lenght:f2}");