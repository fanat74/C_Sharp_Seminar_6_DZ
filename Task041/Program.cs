﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2-> 2
// - 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите число М - размер массива");
Console.Write("число М=");
int numberM = Convert.ToInt32(Console.ReadLine());

int[] CreateArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите число с индексом {i} ");
        arr[i] = Convert.ToInt32(Console.ReadLine());

    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int CountPositiveNumbers (int[] arr)
{
    int count=0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>0) 
        {
            count=count+1;
        }
        
    }
    return count;
}

int[] array = CreateArray(numberM);
int countPositiveNumbers = CountPositiveNumbers(array);
PrintArray(array);
Console.WriteLine($"Количество чисел больше нуля, введенных пользователем  = {countPositiveNumbers}");
