// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int Prompt (string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

bool True (int numb)
{
    if (numb <= 7 && numb > 0){
        return true;
    }
    System.Console.Write($"Вашего дня недели: {numb} не существует");
    return false;

}

void Day (int num)
{
   if (num >= 6)
   {
    System.Console.Write("ваш день недели выходной");
   }
   else
   {
    System.Console.Write("ваш день недели рабочий");
   }
}


int number = Prompt("ведите число: ");
if (True(number))
{
    Day(number);
}