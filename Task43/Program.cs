//  Задача 43
//  Напишите программу, которая найдет точку пересечения двух прямых, 
//  заданных уравнениями y = k1 * x + b1 , y = k2 * x + b2 ; значения b1, k1, b2, k2 задаются пользователем.

//  b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5: -0,5)

//  Приравниваем правые части данных равенств: 
//  k1 * x + b1 = k2 * x + b2 
//  выразим отсюда x: 
//  x = (b2 - b1) / (k1 - k2) 
//  Затем подставим полученное значение х в выражение для у: 
//  y = k1 * (b2 - b1) / (k1 - k2) + b1 

//  Получаем: 
//  x = (b2 - b1) / (k1 - k2)  
//  y = k1 * (b2 - b1) / (k1 - k2) + b1



double[] GenerateArray()
{
    string[] str;
    Console.WriteLine("Введите числа через , :");
    str = Console.ReadLine().Split(",");

    double[] numbers = new double[str.Length];
    for(int i = 0; i < str.Length; i++)
    {
        numbers[i] = Convert.ToDouble(str[i]);
    }

    return numbers;
}


//=======================  ФУНКЦИЯ ПО РАСЧЕТУ ТОЧКИ ПЕРЕСЕЧЕНИЯ 2-Х ПРЯМЫХ  ======================
void IntersectionPoint(double[] array)
{
    double b1 = array[0];
    double k1 = array[1];
    double b2 = array[2];
    double k2 = array[3];

    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * (b2 - b1) / (k1 - k2) + b1;

    Console.Write($"Точка пересечения для заданных данных будет: x = {x}, y = {y}.");
}


void Main()
{
    double[] array = GenerateArray();
    IntersectionPoint(array);
}

Main();
