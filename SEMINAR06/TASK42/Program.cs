//задача 42 Напишите программу, которая будет преобразовывать десятичное число в двоичное. 
 
Console.WriteLine("Введите число"); 
int num = Convert.ToInt32(Console.ReadLine()); 
FromTen(num); 
 
void FromTen(int num) 
{ 
    string count = ""; 
    while (num > 1) 
    { 
        count = Convert.ToString(num % 2) + count; 
        num = num / 2; 
    } 
    count = 1 + count; 
    Console.WriteLine(count); 
}
