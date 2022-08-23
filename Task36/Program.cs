// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.


void fullArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 5);
    }
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
}

int[] array = new int[5];
fullArray(array);
printArray(array);
Console.WriteLine();
int sum = 0;

for (int i = 0; i < array.Length; i += 2)
{
    sum += array[i];
}
Console.WriteLine($"сумма элементов на нечётных позициях: {sum}");