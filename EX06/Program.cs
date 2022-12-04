// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите координату Х");
int x  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y");
int y  = Convert.ToInt32(Console.ReadLine());
CheckKoord(x, y);
// if (x>0 && y>0) Console.WriteLine("Это четверть № 1");
// else if (x>0 && y<0) Console.WriteLine("Это четверть № 4");
// else if (x<0 && y>0) Console.WriteLine("Это четверть № 2");
// else if (x<0 && y<0) Console.WriteLine("Это четверть № 3");
// else Console.WriteLine("Точка находится на оси");

void CheckKoord (int x, int y) // нечего не возвращает, но что-то делает
{
    if (x>0 && y>0) Console.WriteLine("Это четверть № 1");
    else if (x>0 && y<0) Console.WriteLine("Это четверть № 4");
    else if (x<0 && y>0) Console.WriteLine("Это четверть № 2");
    else if (x<0 && y<0) Console.WriteLine("Это четверть № 3");
    else Console.WriteLine("Точка находится на оси");
}