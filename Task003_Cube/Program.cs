// Задача 3
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
int Prompt(string msg)
{
     System.Console.Write(msg);
     int number = Convert.ToInt32(Console.ReadLine());
     return number;
}
bool ValidateNumber(int number)
{
     if (number <= 0)
     {
     System.Console.WriteLine("Это число не натуральное");
     return false;
     }
return true;     
}
int number = Prompt("Введите натуральное число: ");
if (ValidateNumber(number))
{
     for (int i = 1; i <= number; i++)
     {
     System.Console.WriteLine($"{i} -> {Math.Pow(i,3)}");
     }
}
