// Задача 67: Напишите программу, которая будет принимать на вход число
// и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int SumNumber(int number)
{   
    int result;
    if (number < 10)
    {
        return number;
    } 
    result = number % 10;
    return result = result + SumNumber(number /10);
}

int sum = SumNumber(2345);
Console.WriteLine(sum);