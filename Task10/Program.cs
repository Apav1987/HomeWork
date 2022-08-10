Console.Write("Введите трехзначное целое число ");
int a =Convert.ToInt32(Console.ReadLine());

int thirdDel = a / 10; //убираем третью цифру

Console.WriteLine(thirdDel%10); // вторая цифра трехзначного числа