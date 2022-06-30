// Задача 10

int number = new Random().Next(100, 999);
Console.WriteLine("Исходное число " + number);
int number2 = (number / 10) % 10;
Console.WriteLine("Втрое число " + number2);