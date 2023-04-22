// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
// Console.Clear();
// Console.Write("Enter a number raised to a power ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter enter a number indicating the degree ");
// int y = Convert.ToInt32(Console.ReadLine());
// double xy = Math.Pow(x,y);
// Console.WriteLine($"{x} to the power of {y} = {xy}");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// Console.Write("Write count ");
// int number = Convert.ToInt32(Console.ReadLine());
// int result = 0;
// while (number > 0)
// {
//   result = result + number % 10;
//   number = number / 10;
// }
// Console.WriteLine($"Sum of numbers in count = {result}");




// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

// int Prompt(string message)
// {
//   Console.Write(message);
//   string ReadInput = Console.ReadLine();
//   int result = int.Parse(ReadInput);
//   return result;
// }

// int[] GenerateArray(int Length, int minValue, int maxValue)
// {
//   int[] array = new int[Length];
//   Random random = new Random();
//   for (int i = 0; i < Length; i++)
//   {
//     array[i] = random.Next(minValue, maxValue + 1);
//   }
//   return array;
// }

// void PrintArray(int[] array)
// {
//   Console.Write("[");
//   for (int i = 0; i < array.Length; i++)
//   {
//     Console.Write($"{array[i]}, ");
//   }
//   Console.Write($"{array[array.Length - 1]}");
//   Console.WriteLine("]");
// }

// int length = Prompt("The length of massive ");
// int min = Prompt("The lowest meaning of count ");
// int max = Prompt("The biggest meaning of count ");
// int[] array = GenerateArray(length, min, max);
// PrintArray(array);