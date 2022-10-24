// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
// Без использования строк

// 14212 -> нет

// 12821 -> да

// 23432 -> да
int Prompt(string msg)
{
     System.Console.Write(msg);
     int number = Convert.ToInt32(Console.ReadLine());
     return number;
}
bool ValidateNumber(int number)
{
     if (number < 10000 || number >= 100000)
     {
          System.Console.WriteLine("Это число не пятизначное");
          return false;
     }
     return true;
}

int number = Prompt("Введите пятизначное натуральное число: ");
if (ValidateNumber(number))
{
     int a = number / 10000;
     int tempb = number / 1000;
     int b = tempb % 10;
     int tempc = number / 100;
     int c = tempc % 10;
     int tempd = number / 10;
     int d = tempd % 10;
     int e = number / 10000;
     if (a == e && b == d)
     {
          System.Console.WriteLine($"Число {number} является палиндромом");
     }
     else
     {
          System.Console.WriteLine($"Число {number}  не является палиндромом");
     } 
}