// Задача - проверить делиться ли заданное число сразу на 4 и 6 без остатка.

Console.WriteLine("Введите целое число:");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 4 == 0 && num % 6 == 0) Console.WriteLine("Введенное число делится без остатка на 4 и 6");
else Console.WriteLine("Введенное число НЕ делится без остатка на 4 и 6");