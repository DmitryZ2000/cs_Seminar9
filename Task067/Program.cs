// Задача 67: Напишите программу, которая будет принимать на вход число
// и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int SumNumber(int number)
{
    if (number < 10) return number;
    int result = number % 10;
    return result + SumNumber(number / 10);
}

int sum = SumNumber(2345);
Console.WriteLine(sum);