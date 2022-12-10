// Урок 4. Функции
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void Exponentiation(int x, int y)
{   int exp = x;
    if (y==0)
    exp=1;
    else
    {
        for (int i=1; i<=y-1;i++)
        exp =exp*x;
    }
    Console.WriteLine($"A^B={exp}");
}
    Console.WriteLine("Введите число A: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число B: ");
    int b = Convert.ToInt32(Console.ReadLine());

Exponentiation(a,b);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int sum = 0;

int SumOfNumbers(int num)
{   int NumDec=num;
    while (NumDec > 0)
    {   sum = sum + NumDec%10;
        NumDec = NumDec / 10;
    }
    return sum;
}
    SumOfNumbers(num);
    Console.WriteLine($"Сумма цифр в числе {num}={sum}");


// Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


l1: Console.WriteLine("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
if (length==0) 
{
    Console.WriteLine($"Длина массива должна быть больше 0");
    goto l1;
}
int[] UserArray()
{
    int [] array = new int [length];
    for (int i = 0; i < length; i++)
    {   Console.WriteLine($"Введите элемент {i+1} массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    }
return array;
}
void ShowArray (int[] arr)
{   Console.WriteLine($"Массив, введенный вами:");
    for (int i = 0; i < length; i++)
    Console.Write($"{arr[i]} ");
    Console.WriteLine();
}
ShowArray(UserArray());