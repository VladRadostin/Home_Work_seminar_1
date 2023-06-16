// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int Prompt (string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int SecondDigitDelete(int num)
{
    int result = num / 10 % 10;
    return result;
}

int number = Prompt("ведите трехзначное число: ");

if (number < 100 || number >= 1000)
{
    System.Console.WriteLine($"Ваше число: {number} не трехзначное");
    return;
}

System.Console.WriteLine($"Ваше число: {number}");
System.Console.WriteLine($"Вторая цифра {SecondDigitDelete(number)}");

