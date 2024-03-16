// // Задача #1.

// void HW1(int a)
// {
//     if (a % 7 == 0 && a % 23 == 0)
//     {
//         System.Console.WriteLine($"a={a} => YES");
//     }
//     else
//     {
//         System.Console.WriteLine($"a={a} => NO");
//     }

// }

// System.Console.Write("Input number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());


// HW1(num1);


// --------------------------------------------------------------------------------------------------

// Задача #2

// void Coord(int x, int y)
// {
//     if (x > 0 && y > 0)
//     {
//         System.Console.WriteLine($"X={x}, Y={y} => I quarter");
//     }
//     else if (x > 0 && y < 0)
//     {
//         System.Console.WriteLine($"X={x}, Y={y} => IV quarter");
//     }
//     else if (x < 0 && y < 0)
//     {
//         System.Console.WriteLine($"X={x}, Y={y} => III quarter");
//     }
//     else if (x < 0 && y > 0)
//     {
//         System.Console.WriteLine($"X={x}, Y={y} => II quarter");
//     }
// }

// System.Console.Write("Input X coordinate: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input Y coordinate: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// Coord(num1, num2);

// ------------------------------------------------------------------------------------------------------

//Задача #3

// void HW3(int num)
// {
//     if (IsThreeDigit(num))
// {
//     int ed = num % 10;
//     int dec = num / 10 % 10;
//     int res = (int)Math.Pow(dec,ed);//int res = Convert.ToDoubleMath.Pow(dec,ed);
//     if (ed < dec)
//     System.Console.WriteLine($"{num}  => {dec}");
//     else if (ed > dec)
//     System.Console.WriteLine($"{num}  => {ed}");
//     else if (ed == dec)
//     System.Console.WriteLine($"{num}  => Числа равны");
// }
//     else
//     System.Console.WriteLine($"Incorrect input!!!");
// }
// bool IsThreeDigit(int num)
// {
//     if(num >= 10 && num <=99)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }

// System.Console.Write("Input number between 10 & 99: ");
// int num = Convert.ToInt32(Console.ReadLine());

// HW3(num);

// ------------------------------------------------------------------------------------------------------

// Задание 4
// КОММЕНТАРИЙ: С этой задачей возникли сложночти, пришлось посмотреть частично решение, к сожалению, но тем не менее 
// по порядку цифры у меня вывести не получилось, только лишь в обртаном порядке.

Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N < 10)
{ Console.WriteLine(N); }
else
{
    while (N > 0)
    {
        int currentDigit = N % 10;
        N /= 10;
        if (N > 0)
        {
            Console.Write(currentDigit + ",");
        }
        else
        {
            Console.WriteLine(currentDigit);
        }
    }
}

