// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве. 
// [1 2 3 4 5] -> 5 8 3 
// [6 7 3 6] -> 36 21 
int[] CreateArray(int size)  // принимает размер массива и возвращает сгенерированный массив 
{ 
    int[] array = new int[size]; 
    for (int i = 0; i < size; i++) 
        array[i] = new Random().Next(-10, 10); 
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
 
int[] CreateNewArray(int[] array) 
{ 
    int size = array.Length / 2; 
    if (array.Length % 2 == 1) 
        size = array.Length / 2 + 1; 
    int[] newArray = new int[size]; 
    for (int i = 0; i < size; i++) 
        newArray[i] = array[i] * array[array.Length - i - 1]; //^1 
    if (array.Length % 2 > 0) 
    { 
        newArray[size - 1] = array[array.Length / 2]; // 
    } 
    return newArray; 
} 
 
int size = 5; 
int[] array = CreateArray(size); 
PrintArray(array); 
PrintArray(CreateNewArray(array));
