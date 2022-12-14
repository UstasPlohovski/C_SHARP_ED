// Задача 31: Задайте массив из N элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] CreateArray(int size)  // принимает размер массива и возвращает сгенерированный массив
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(-9, 10);
    return array;
}

void PrintArray(int[] array)
{
    foreach (int el in array)   //этот цикл только для просмотра и тут нет индексов
        Console.Write($"{el} ");
    // for (int i = 0; i < array.Length; i++)
    //     Console.Write($"{array[i]} ");
    Console.WriteLine();
}

int[] FindSums(int[] array)
{

    int SumP = 0;
    int SumN = 0;
    foreach (int el in array)
    {
        if (el > 0) SumP += el; // SumP=SumP+el
        else SumN += el;  // SumN=SumN+el
    }
    int[] results = {SumP, SumN};
    return results;
}

Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);
PrintArray(array);

int[] sums = FindSums(array);
Console.WriteLine($"Сумма всех положительных элементов равна {sums[0]}");
Console.WriteLine($"Сумма всех отрицательных элементов равна {sums[1]}");
