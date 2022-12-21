// Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
// рассматриваем только квадратные массивы.
// и потом надо найти сумму элементов обратной диагонали.

Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива");
int cols = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [rows, cols];
FillArray(array);
PrintArray(array);
ChangeArray(array);
reverse(array);

void FillArray(int[,] array)
{
    for (int i=0;i<array.GetLength(0);i++)
        for (int j=0;j<array.GetLength(1);j++)
            array[i,j] = new Random().Next(-20,21);
}

void PrintArray(int[,] array)
{
    for (int i=0;i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)
            Console.Write($"{array[i,j],3}\t");
        Console.WriteLine();  
    }
}
void ChangeArray(int[,] array)
{
    int res = 0;
    for (int i=0;i<array.GetLength(0);i++)
        for (int j=0;j<array.GetLength(1);j++)
            if (i==j)
                {
                    res += array[i,j];
                }
    Console.WriteLine(res);
}
void reverse (int [,] array)
{
    int res2 = 0;
    for (int i =0; i < array.GetLength(0); i++)
    {
        for (int j =cols-1; j >= 0; j--)
        {
            res2=res2+array[i,j];
            i++;
        }
    }
   Console.WriteLine(res2); 
}
