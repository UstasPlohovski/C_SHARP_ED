//Задайте одномерный массив из 15 случайных чисел от -100 до 100. Найдите количество элементов массива,
// значения которых лежат в отрезке [10,99].  
 
int[] CreateArray(int size)  // принимает размер массива и возвращает сгенерированный массив 
{ 
    int[] array = new int[size]; 
    for (int i = 0; i < size; i++) 
        array[i] = new Random().Next(-100, 100); 
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
int CountNumbers(int[] array) 
{ 
    int count = 0; 
    for (int i = 0; i < array.Length; i++) 
        if (array[i] >= 10 && array[i] < 100) 
            count++; 
    return count; 
} 
 
 
int[] array = CreateArray(15); 
PrintArray(array); 
Console.WriteLine(CountNumbers(array));
