// Задача 19 Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве. A (3,6); B (2,1) -> 5,09 A (7,-5); B (1,-1) -> 7,21 

try
{
    Console.WriteLine("Введите координату A, два числа сначала по X далее по Y:");
    int ax = Convert.ToInt32(Console.ReadLine());
    int ay = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату B, два числа сначала по X далее по Y:");
    int bx = Convert.ToInt32(Console.ReadLine());
    int by = Convert.ToInt32(Console.ReadLine());
    
    //double r = distance(ax,ay,bx,by);
    //Console.WriteLine($"Расстояние между точками A и B: {r}");
    Console.WriteLine($"Расстояние между точками A и B: {distance(ax,ay,bx,by)}");

}
catch // если же не получилось выполнить всю программу, то уходим в этот блок и информуруем пользователя
{
    Console.WriteLine("Ошибка: Надо было вводить именно целое число цифрами!");
}

// Функция возвращает число double ----------------------------------------------------

double distance (int ax, int ay, int bx, int by)
{
    double d = Math.Sqrt((ax-bx)*(ax-bx)+(ay-by)*(ay-by));
    return d;
}