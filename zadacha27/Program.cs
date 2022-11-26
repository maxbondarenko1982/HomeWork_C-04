// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumnumbers = 0;

while (number > 0)
{
    int digits = number % 10;
    sumnumbers = sumnumbers+digits;
    number = number/10;

}
Console.WriteLine(sumnumbers);

