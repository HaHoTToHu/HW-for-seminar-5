/*Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет 
количество чётных чисел в массиве.*/
// int[] CreateArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();

// }

// void Positivcik(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//         {
//             count += 1;
//         }
//     }
//     Console.WriteLine($"Количество чётных элементов в массиве равно: {count}");
// }

// Console.WriteLine("Задайте размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int min = 100;
// int max = 1000;

// int[] array = CreateArray(size, min, max);
// ShowArray(array);
// Positivcik(array);

/*Задача 35: Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, значения которых лежат 
в отрезке [10,99]. Пример для массива из 5, а не 123 элементов. 
В своём решении сделайте для 123*/
// int[] CreateArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void Otrezok(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >= 10 && array[i] <= 99)
//         {
//             count += 1;
//         }
//     }
//     Console.WriteLine($"Количество элементов в отрезке [10,99] равно: {count}");
// }

// int size = 123;
// int min = 0;
// int max = 123;
// int[] array = CreateArray(size, min, max);
// Otrezok(array);
// ShowArray(array);

/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.*/
// int[] CreateArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void NecetPos(int[] array)
// {
//     int sum = 0;
//     for (int i = 1; i < array.Length; i += 2)
//     {
//         sum += array[i];
//     }
//     Console.WriteLine($"Сумма элементов на нечётных позициях равна: {sum}");
// }

// Console.WriteLine("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите min- имум массива: ");
// int min = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите max- имум массива: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateArray(size, min, max);
// ShowArray(array);
// NecetPos(array);

/*Задача 38: Задайте массив вещественных чисел. Найдите разницу 
между максимальным и минимальным элементов массива.*/
// double[] CreateArray(int size)
// {
//     double[] array = new double[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = Math.Round((new Random().NextDouble() * 100),2);
//     }
//     return array;
// }

// void ShowArray(double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// double[] Raznitza(double[] array)
// {
//     double raznitza = 0;
//     double minim = array[0];
//     double maxim = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < minim)
//         {
//             minim = array[i];
//         }
//         else if (array[i] > maxim)
//         {
//             maxim = array[i];
//         }
//     }
//     Console.WriteLine($"Разница между макс-м и мин-м элементом будет равна: {raznitza = Math.Round((maxim - minim), 2)}");
//     return array;
// }

// Console.WriteLine("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());

// double[] array = CreateArray(size);
// ShowArray(array);
// double[] raznitza = Raznitza(array);

/*Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.*/
// int[] CreateArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// int[] NewArray(int[] array)
// {
//     int l = array.Length;
//     int proizv = 0;
    
//     for (int i = 0; i < l / 2; i++)
//     {
//         int temp = array[i];
//         temp = array[l-1-i];
        
//         proizv = array[i] * array[l-1-i];
//         Console.WriteLine($"Произведение соседних пар элементов массива равно: {proizv}");
//         array[l-1-i] = temp;
//     }
//     return array;
// }

// Console.WriteLine("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите min массива: ");
// int min = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите max массива: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateArray(size, min, max);
// ShowArray(array);
// int[] newArray = NewArray(array);