// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(10, 20);
    Console.Write(array[i] + " ");
}

int max = array[0];
int min = array[0];

for (int i = 1; i < array.Length; i++)
{
    if (max < array[i]) max = array[i];

    if (min > array[i]) min = array[i];
}

int sum = max - min;

Console.WriteLine($"разница между максимальным и минимальным {max} , {min} элементами = {sum}");