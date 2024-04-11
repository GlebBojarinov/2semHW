// Задача #1

// void PrintNaturalNumbers(int m, int n)
// {
//     if (m == 0 || n == 0) return;
//     if (m < n)
//     {
//         Console.Write($"{m}, ");
//         PrintNaturalNumbers(m + 1, n);
//         return;
//     }
//     else
//     {
//         if (m > n)
//         {
//             Console.Write($"{m}, ");
//             PrintNaturalNumbers(m - 1, n);
//             return;
//         }
//     }

//     if (m == n)
//     {
//         Console.Write($"{m}, ");
//         return;
//     }
// }

// Console.WriteLine("Enter a natural number M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter a natural number N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// PrintNaturalNumbers(m, n);

//Задача #2



// int FunktionAKK(int m, int n)
// {
//     if (m == 0) return n + 1;
//     else if (n == 0 && m > 0) return FunktionAKK(m - 1, 1);
//     else return FunktionAKK(m - 1, FunktionAKK(m, n - 1));
// }

// Console.WriteLine("Enter a natural number M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter a natural number N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write($"A(m,n) = {FunktionAKK(m, n)}");

// Задача #3

int[] array = { 3, 7, 11, 0, 25, 59 };

string PrintArray(int[] array)
{
    return string.Join(" ", array);
}

int[] ArraySwap(int[] array, int index)
{
     if (index <= 0)
    {
        return array;
    }
    int temp = array[index];
    array[index] = array[array.Length - index - 1];
    array[array.Length - index - 1] = temp;
    return ArraySwap(array, index -= 2);
}

Console.WriteLine($"{PrintArray(ArraySwap(array, array.Length - 1))}");