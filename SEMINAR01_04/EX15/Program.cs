// Задача 29: Напишите программу, которая задаёт массив из 8 целых чисел с клавиатуры и далее выводит массив на экран в одну строку.

Console.WriteLine("Введите размер массива (N): ");                  // определяем размер массива
int N = Convert.ToInt32(Console.ReadLine());

int[] Array1 = new int[N];                                          // создаем пустой массив заданного размера
// for (int i = 0; i < ArrayA.Length; i++)
// {
//     Console.WriteLine($"Введите значение {i}-го индекса массива");
//     ArrayA[i] = Convert.ToInt32(Console.ReadLine());
// }
ReadArray1(N);
Console.WriteLine();
WriteArray1(Array1);
// Console.Write("You have new array; [");
// for (int i = 0; i < (Array1.Length - 1); i++)
// {
//     Console.Write($"{Array1[i]}; ");
// }
// Console.Write($"{Array1[^1]}]");

// Скоректировать течатный текст и разбить на функции

int [] ReadArray1(int N)
{
    int[] Array1 = new int[N]; 
    for (int i = 0; i < Array1.Length; i++)
    {
        Console.WriteLine($"Введите значение {i}-го индекса массива");
        Array1[i] = Convert.ToInt32(Console.ReadLine());
    }
    return Array1;
}

void WriteArray1(int []Array1)
{
    Console.Write("You have new array; [");
    for (int i = 0; i < (Array1.Length - 1); i++)
    {
        Console.Write($"{Array1[i]}; ");
    }
    Console.Write($"{Array1[^1]}]");
}