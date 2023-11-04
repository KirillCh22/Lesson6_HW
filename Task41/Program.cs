// Задача 41
//  Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел больше 0 ввел пользователь.
// * 0, 7, 8, -2  ->  2
// * -1, -7, 567, 89, 223  ->  3


int[] GenerateArray()
{
    string[] str;
    Console.WriteLine("Введите числа через , :");
    str = Console.ReadLine().Split(",");

    int[] numbers = new int[str.Length];
    for(int i = 0; i < str.Length; i++)
    {
        numbers[i] = Convert.ToInt32(str[i]);
    }

    return numbers;
}


void PrintArray(int[] array)
{
    Console.WriteLine();
    Console.Write("Массив: [");
    for(int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1) Console.Write(array[i] + "]");
        else Console.Write(array[i] + ", ");
    }
}


void CountNegativeNumbers(int[] array)
{
    Console.WriteLine();
    int negative_numbers = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0 ) negative_numbers++; 
    }

    Console.Write($"Количество чисел больше 0, которые ввел пользователь - {negative_numbers}.");
}


void Main()
{
    int[] array = GenerateArray();
    PrintArray(array);
    Console.WriteLine();
    CountNegativeNumbers(array);
}


Main();