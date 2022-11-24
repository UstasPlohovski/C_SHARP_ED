// int num = new Random().Next(10,100);
Console.WriteLine($"Сгенерированно случайное число {num}");
int max = num / 10;
if (num%10 > max)  max = num%10;
Console.WriteLine($"Наибольшая цифра {max}");

for (int i=0;i<=num;i++) Console.Write($"{i}, ");

// Задача 2 - из двух чисел найти минимальное и максимальное

Console.Write("Enter the first any integer:");

int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the second any integer:");

int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)