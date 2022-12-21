// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:

Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива");
int cols = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [rows, cols];
FillArray(array);
PrintArray(array);
ChangeArray(array);
PrintArray(array);

void FillArray(int[,] array)
{
    for (int i=0;i<array.GetLength(0);i++)
        for (int j=0;j<array.GetLength(1);j++)
            array[i,j] = new Random().Next(-20,21);
    Console.WriteLine();
}

void ChangeArray(int[,] array)
{
    for (int i=1;i<array.GetLength(0);i++)
        for (int j=1;j<array.GetLength(1);j++)
            if (i%2 != 0 && j%2 != 0)
            {
                array[i,j] = array[i,j]*array[i,j];
            }
    Console.WriteLine();
}

void PrintArray(int[,] array)
{
    for (int i=0;i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)
            Console.Write($"{array[i,j],3}\t");
        Console.WriteLine();  
    }
    Console.WriteLine();
}