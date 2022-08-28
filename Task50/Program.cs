// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("поиск элемента в массиве 10х10, введите номер строки: ");
int Lines = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите номер столбца:");
int Colums = Convert.ToInt32(Console.ReadLine());

void FillNums(int[,] num)
{
    for (int i = 0; i < num.GetLength(0); i++)
    {
        for (int j = 0; j < num.GetLength(1); j++)
        {
            num[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintNums(int[,] num)
{
    for (int i = 0; i < num.GetLength(0); i++)
    {
        for (int j = 0; j < num.GetLength(1); j++)
        {
            Console.Write($"{num[i, j]} ");
        }
        Console.WriteLine();
    }

}

int[,] nums = new int[10, 10];
FillNums(nums);
PrintNums(nums);

if (Lines > nums.GetLength(0) || Colums > nums.GetLength(1))
{
    Console.WriteLine("пазиции такого элемента нет");
}
else
{
    Console.WriteLine($"в случайном массиве,позиция эл. на {Lines} строке и {Colums} столбце = {nums[Lines - 1, Colums - 1]}");
}
