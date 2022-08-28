// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("для заполнения массива целыми числами, введите колличество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("и колличество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());


void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)

{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

int[,] nums = new int[m, n];
FillArray(nums);
PrintArray(nums);

for (int j = 0; j < nums.GetLength(1); j++)
{
    double result = 0;
    for (int i = 0; i < nums.GetLength(0); i++)
    {
        result = (result + nums[i, j]);
    }
    result = result / n;
    Console.Write(result + "; ");
}
Console.WriteLine("среднее арифметическое каждого столбца.");