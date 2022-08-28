// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("введите число m ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите число n ");
int n = Convert.ToInt32(Console.ReadLine());


void PrintArray(double[,] matr)
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

void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = Convert.ToDouble(new Random().Next(-1, 10)) / 10;
        }
    }
}

double[,] nums = new double[m, n];


FillArray(nums);
PrintArray(nums);
