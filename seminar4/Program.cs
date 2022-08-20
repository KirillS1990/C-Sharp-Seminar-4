// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.Clear();
// Console.Write("Введите число A: ");
// int num = int.Parse(Console.ReadLine());
// Console.Write("Введите число B: ");
// int n = int.Parse(Console.ReadLine());
// int num_n = 1;
//     for (int i = 0; i < n; i++)
//     {
//         num_n *= num;
//     }
// Console.WriteLine($"Число {num} в степени {n} равно - {num_n}");


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// Console.Clear();
// static int SumOfDigits(int n)
//     {
//         int sum = 0;
//         while (n > 0) { sum += n % 10; n /= 10; }
//         return sum;
//     }
// Console.Write("Введите число: ");
// Console.WriteLine(SumOfDigits(int.Parse(Console.ReadLine())));
       


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// Console.Clear();
// int[] array = new int [8];
// Random rnd = new Random();
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = rnd.Next(0, 11);
//     Console.Write ($"{array[i]}" + (i < array.Length - 1 ? ",":""));
// }




