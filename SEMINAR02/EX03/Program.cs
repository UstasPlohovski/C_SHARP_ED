// Задача - определить является ли второе число кратным первому

Console.WriteLine("Enter two numbers:");
int n1 = Convert.ToInt32(Console.ReadLine());
int n2 = Convert.ToInt32(Console.ReadLine());

if (n2 % n1 == 0) Console.WriteLine("The second number is a multiple of the first.");
else
{
    Console.WriteLine("The second number is NOT a multiple of the first.");
    int r = n2 % n1;
    Console.WriteLine($"The residue  is {r}");
}