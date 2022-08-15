Console.Write("Введите пятизначное число: ");
string a = Console.ReadLine();

  if (a[0]==a[4] & a[1]==a[3]){
    Console.WriteLine($"Ваше число: {a} - палиндром.");
  }
  else Console.WriteLine($"Ваше число: {a} - Не палиндром.");

