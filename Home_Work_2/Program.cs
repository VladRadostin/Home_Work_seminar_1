// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Prompt (string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int Get (int num)
{
    while (num > 999){
        num = num / 10;
    }
    return num % 10;

}

bool True (int numb)
{
    if (numb < 100){
        System.Console.Write($"Ваше число: {numb} не трехзначное");
        return false;

    }
    return true;
}

int number = Prompt("ведите число: ");
if (True(number))
{
    System.Console.Write(Get(number));
}
