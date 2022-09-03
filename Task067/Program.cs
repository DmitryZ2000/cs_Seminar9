// Задача 67: Напишите программу, которая будет принимать на вход число
// и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int SumNumber(int number)
{
    if (number < 10)
    {
               
    }
    number =number /10;
    SumNumber(number % 10);
}

int sum = SumNumber(275);
Console.WriteLine(sum);