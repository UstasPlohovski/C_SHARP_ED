// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве. 
// 4; массив [6, 7, 19, 345, 3] -> нет 
// -3; массив [6, 7, 19, 345, 3] -> да 
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
bool CheckNumberIn(int number, int[] array) 
{ 
    bool find = false; 
    foreach (int el in array) 
    { 
        if (el == number) 
        { 
            find = true; 
            break; 
        } 
    } 
    return find; 
} 
 
Console.Write("Введите размерность массива "); 
int size=Convert.ToInt32 (Console.ReadLine()); 
Console.Write("Введите число "); 
int number=Convert.ToInt32 (Console.ReadLine()); 
int[] maxArray=CreateArray(size); 
PrintArray(maxArray); 
Console.WriteLine(CheckNumberIn(number,maxArray));
