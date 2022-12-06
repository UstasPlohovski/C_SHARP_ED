// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке. [1,0,1,1,0,1,0,0] 
// Далее обернуть всё это в функцию, конечно же , здесь нужна функция которая красиво выводит массив через запятую, создать функцию булевого типа , которая определяет больше ли 1 чем 0 в массиве 
 
int[] array = new int[8]; 
for (int i = 0; i < 8; i++) 
    array[i] = new Random().Next(0, 2); 
PrintArray(array); 
if (Check1(array)) 
    Console.WriteLine("Единиц больше, чем нулей!"); 
else    Console.WriteLine("Нулей не меньше, чем единиц!"); 
 
void PrintArray(int[] a) 
{ 
    for (int i = 0; i < a.Length - 1; i++) 
        Console.Write($"{a[i]}, "); 
    Console.WriteLine($"{a[^1]}"); 
} 
 
 
 
bool Check1(int[] a) 
{ 
    int sum = 0; 
    for (int i = 0; i < a.Length; i++) 
    { 
        sum = sum + a[i]; 
    } 
    if (sum > a.Length / 2) 
        return true; 
    else return false; 
}