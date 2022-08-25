// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Введи число (длинна массива): ");

int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

void InputArray(int size)
{
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введи {i + 1} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int Different(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            count++;
    }
    return count;
}

InputArray(size);
Console.WriteLine($"чисел больше нуля: {Different(array)}");


