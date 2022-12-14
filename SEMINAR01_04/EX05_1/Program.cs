// Задача - определить третью цифру слева в любом произвольном заданном целом числе.
//    (решение через цикл)

Console.WriteLine("Enter number");
int Number = Convert.ToInt32(Console.ReadLine());
int CurrentNumber = 0, Remainder = 0;

if (Number > 99)
{
    CurrentNumber = Number;
    while (CurrentNumber >= 1000)
    {
        CurrentNumber /= 10;
        Remainder = CurrentNumber % 10;
    }
    Console.WriteLine($"The third number from the left is {Remainder}");
}
else
{
Console.WriteLine("The thidr number isn't in the number");
}