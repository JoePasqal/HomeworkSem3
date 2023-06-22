// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите ПЯТИЗНЧНОЕ число, я проверю - является ли оно палиндромом");
int number = Convert.ToInt32(Console.ReadLine());

int pervoe = number / 10000;
int vtoroe = (number / 1000) % 10;
int tretye = (number / 100) % 10;
int chetvertoe = (number / 10) % 10;
int pyatoe = number % 10;

if(pervoe == pyatoe && vtoroe == chetvertoe)
{
    Console.Write($"Число {number} является палиндромом");
}
else
{
    Console.Write($"Число {number} не является палиндромом"); 
}