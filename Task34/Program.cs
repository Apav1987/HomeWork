// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
Console.WriteLine();
int[] array = new int[4];

void fullArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
}
fullArray(array);
printArray(array);

Console.WriteLine();

int Pos(int[] array)
{
    int s = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            s++;
        }
    }
    return s;
}

Console.WriteLine();

int s = Pos(array);
Console.WriteLine($"Количество чётных чисел: {s}");