// Console.WriteLine("Enter any number:");
// int Number = Convert.ToInt32(Console.ReadLine());
// int Size = Math.Floor(Math.Log10(Number)) + 1; // определение сколько десятичных разрядов имеет введенное число через применение функции Log(10)
// Console.WriteLine($"Введенное число имеет разрядность {Size}");
// int CountIteration = Math.Floor(Size / 2); // определяем количество проверок соотвертсвия внутри числа, через Math.Floor потому,что колличество цифр в числе может быть не четным
// int Result = 0;
// int NumberPoint = 1;

// while (NumberPoint <= CountIteration)
// {
// 	// if (Result == 0)
// 	// 	{
// 		int NumberLeft = Math.Floor((Number / Math.Pow(10 , (Size-NumberPoint)))%10);
// 		Console.WriteLine($"NumberLeft {NumberLeft}");
// 		int NumberRight = Math.Floor(((Number / Math.Pow(10, NumberPoint-1)) % 10));
// 		Console.WriteLine($"NumberLeft {NumberRight}");
// 		int Result = (NumberLeft - NumberRight);
//         NumberPoint = NumberPoint++;
//         Console.WriteLine($"Введенное число {Number} - палиндром");
// 		// }
// }
// //Console.WriteLine($"Введенное число {Number} - не палиндром");