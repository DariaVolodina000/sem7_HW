// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого числа в массиве нет
// 1, 1 -> 1


void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(-9, 10);
        }
    }
    return arr;
}

int IntPutInt(string message)
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

bool FindPosition(int[,] arr, int strin, int column)
{
    if (strin - 1 >= arr.GetLength(0) || column - 1 >= arr.GetLength(1))
    {
        return false;
    }
    else
    {
        return true;
    }
}

int[,] line = new int[5, 5];
line = FillArray(line);
PrintArray(line);

int str = IntPutInt("введите номер строки: ");
int clm = IntPutInt("введите номер столбца: ");

if (FindPosition(line, str, clm))
    Console.WriteLine($"На этой позиции находится число: {line[str - 1, clm - 1]} ");
else
    Console.WriteLine("Такой позиции в массиве нет");
