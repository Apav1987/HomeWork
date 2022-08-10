Console.Write("Введите число от 1 до 7 ");
int a =Convert.ToInt32(Console.ReadLine());

if ((6==a)^(7==a))
{
    Console.WriteLine("Выходной день");
}
if ((1==a)^(2==a)^(3==a)^(4==a)^(5==a))
{
    Console.WriteLine("Рабочий день");
}