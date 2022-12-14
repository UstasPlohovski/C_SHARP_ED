// Задача - найти наибольшую цифру в двухзнвчном числе.

int num = new Random().Next(10, 100);
Console.WriteLine($"Сгенерировано случайное число {num}");
int max = num / 10;
if (num % 10 > max) max = num % 10;
Console.WriteLine($"Наибольшая цифра в этом числе это {max}");