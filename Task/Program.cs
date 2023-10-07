// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.


using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строки через запятую:");

        string input = Console.ReadLine();
        string[] inputArray = input.Split(',');
        string[] resultArray = FilterArrayByLength(inputArray, 3);

        Console.WriteLine("Результат:");
        foreach (string str in resultArray)
        {
            Console.WriteLine(str);
        }
    }

    static string[] FilterArrayByLength(string[] inputArray, int maxLength)
    {
        int count = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= maxLength)
            {
                count++;
            }
        }

        string[] resultArray = new string[count];
        int resultIndex = 0;

        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= maxLength)
            {
                resultArray[resultIndex] = inputArray[i];
                resultIndex++;
            }
        }

        return resultArray;
    }

}