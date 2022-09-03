void PrintNumbers(int start, int end)
{
    if (start > end) return;
    Console.Write($"{start} ");
    PrintNumbers(start + 1, end);
}

// Console.Write("Введите любое целое число ");
// int number = Convert.ToInt32(Console.ReadLine());
int start = 4;
int end = 7;
PrintNumbers(start, end);