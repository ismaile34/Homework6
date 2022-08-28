// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение
    int result = Convert.ToInt32(Console.ReadLine()); // Преобразует строку в целое число
    return result; // Возвращает результат функции
}

void NumberCheck(int number)
{
    if (number > 0)
    {
        int [] Array = InputNumbers(number);
        ArrayOut(Array);
        System.Console.WriteLine($"Количество чисел больще нуля =  {PosElement(Array)}");
    }
    else
    {
        System.Console.WriteLine("STOP");
    }
}

int [] InputNumbers(int number)
{
    int[] Array = new int [number];
    int i = 0;
    while (i < number)
    {
        System.Console.Write("Введите число > ");
        Array[i] = int.Parse(Console.ReadLine());
        i++;
    }
    return Array;
}

int PosElement(int[] Array)
{
    int count = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

void ArrayOut(int[] Array)
{
    for (int j = 0; j < Array.Length; j++)
    {
        System.Console.WriteLine($"{Array[j]}");
    }
}
int number = Prompt("Введите количество чисел > ");
NumberCheck(number);
