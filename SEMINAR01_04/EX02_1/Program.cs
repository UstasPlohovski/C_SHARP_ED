// Задача - в трехзначном числе исключить из него среднюю (вторую справа / слева) цифру и записать полученное число. 

int numA = new Random().Next(100, 1000);
Console.WriteLine($"Ваше число {numA}");
int d = numA % 10;
int n = numA / 100;
Console.WriteLine($"{n}{d}");
