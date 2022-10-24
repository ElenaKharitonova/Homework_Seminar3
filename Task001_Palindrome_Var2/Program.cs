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
int number = Prompt("Введите натуральное число: ");
int temp = number;
int result = 0;
while (temp > 0)
{
int remain = temp % 10;
result = result * 10 + remain;
temp = temp / 10;
}
if (result == number)
{
     System.Console.WriteLine($"Число {number} является палиндромом");
}
else
{
     System.Console.WriteLine($"Число {number}  не является палиндромом");
} 