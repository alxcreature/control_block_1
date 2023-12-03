/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами. */

// Метод вывода на экран массива строк с перечислением
void PrintArray(string [] array)
{
    // for (int i = 0; i < array.Length; i++)
    // {
    //     Console.WriteLine($"[{i}] = {array[i]}");
    // }
    Console.WriteLine($"[{String.Join(", ", array)}]");
}

// Ввод массива строк с клавиатуры через пробел
Console.WriteLine("Введите массив строк через пробел:");
string [] arrayStr = Console.ReadLine()!.Split();

// Проверка на минимальное количество введённых строк
if (arrayStr.Length < 2)
{
    Console.WriteLine("Введено менее двух элементов строк!");
    return;
}

int countStr = 0;

// Обход исходного массива строк для вычисления размера нового массива
for (int i = 0; i< arrayStr.Length; i++)
{
    if (arrayStr[i].Length > 3 ) continue;
    countStr++;
}

// Создание нового массива с вычисленной размерностью
string[] arrayStrNew = new string[countStr];
countStr = 0;

// Копирование элементов исходного массива в новый массив согласно условию
for (int i = 0; i < arrayStr.Length; i++)
{
    if (arrayStr[i].Length > 3) continue;

    arrayStrNew[countStr] = arrayStr[i];
    countStr++;
}

// Печать результирующего массива на экран
PrintArray(arrayStrNew);