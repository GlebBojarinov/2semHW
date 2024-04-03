
// Задача 1: Напишите программу, которая бесконечно
// запрашивает целые числа с консоли. Программа
// завершается при вводе символа ‘q’ или при вводе
// числа, сумма цифр которого четная.

// Example: 
// 5 12 16 q [STOP]
// 3 45 342 15 [STOP]

// using System;
// class Program
// {
//     static void Main()
//     {
//         while (true)
//         {
//             System.Console.WriteLine("Введите число или 'q' для выхода: ");
//             string input = Console.ReadLine();

//             if (input == "q")
//             {
//                 break;
//             }
//             int number;
//             if (int.TryParse(input, out number))
//             {
//                 int sum = 0;
//                 while (number > 0)
//                 {
//                     sum += number % 10;
//                     number /= 10;
//                 }
//                 if (sum % 2 == 0)
//                 {
//                     System.Console.WriteLine("STOP");
//                     break;
//                 }
//             }
//             else
//             {
//                 System.Console.WriteLine("Некорректный ввод. Пожалуйста введите целое число или 'q'.");
//             }
//         }
//     }
// }

// Задача 2: Задайте массив заполненный случайными
// трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в
// массиве.

// Example:
// [344 452 341 125] => 2

// int[] CreateArray(int n, int min, int max)
// {
//     int[] array = new int[n];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(100, 999);
//     }
//     return array;
// }

// int EvenNumbersCount(int[] arr)
// {
//     int count = 0;
//     foreach(int item in arr)
//     {
//         if(item % 2 == 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// System.Console.Write("Input size of array: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] arr = CreateArray(size, 100, 999);
// PrintArray(arr);
// System.Console.WriteLine($" => {EvenNumbersCount(arr)}");


// Задача 3: Напишите программу, которая перевернёт
// одномерный массив (первый элемент станет
// последним, второй – предпоследним и т.д.)

// Example:
// [1 3 5 6 7 8] => [8 7 6 5 3 1]

int[] CreateArray(int n, int min, int max)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 9);
    }
    return array;
}

void ReversedArray(int[] array)
{
        for (int i = array.Length-1; i >= 0; i--)
        {
            Console.Write(array[i] + " ");
        }
        System.Console.WriteLine();
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

System.Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArray(size, 1, 9);
PrintArray(arr);
System.Console.Write(" => ");ReversedArray(arr);