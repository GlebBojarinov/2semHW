//Задача #1

// char[,] a = new char[,] { { 'g', 'p', 'z' }, { 'b', 'g', 'm' } };
// string result = CreateStringFrom2DArray(a);
// System.Console.WriteLine(result);

// string CreateStringFrom2DArray(char[,] a)
// {
//     string result = "";
//     for (int i = 0; i < a.GetLength(0); i++)
//     {
//         for (int j = 0; j < a.GetLength(1); j++)
//         {
//             result = result + a[i, j];
//         }
//     }
//     return result;
// }


// Задача #2

// string input = "aBcD1ef!-";

// string result = input.ToLower();

// Console.WriteLine($"{input} => {result}");

//Задача #3


// string input = "deified";
// bool isPalindrome = IsPalindrome(input);
// System.Console.WriteLine(isPalindrome ? "YES" : "NO");

// bool IsPalindrome(string str)
// {
//     string normalized = new string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
//     return normalized.SequenceEqual(normalized.Reverse());
// }