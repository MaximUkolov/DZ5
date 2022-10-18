// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// ////Random rnd = new Random(); - Что бы могла делать эта строка?
// FillArrayRandomNumbers(numbers);
// Console.WriteLine("Массив: ");
// PrintArray(numbers);
// int count = 0;


// for (int i = 0; i < numbers.Length; i++)
// if (numbers[i] % 2 == 0)
// count++;

// Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

// void FillArrayRandomNumbers(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = new Random().Next(100,1000);
//     }
// }
// void PrintArray(int[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }




// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0З


// int[] arr = new int[8];
// int sum1 = 0;
// int sum2 = 0;

// void newArray(int[]array)
// {
//     for (int i=0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-50,50);
//     }
// }

// void PrintArray(int[]array)
// {
//     for (int i=0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]}");
//         if (i < (array.Length)) Console.Write($", ");

//     }
//     Console.WriteLine();
// }

// newArray(arr);
// PrintArray(arr);
// for (int i = 0; i < arr.Length; i++)
//     {
//         if (i % 2 == 0)
//             sum1 = sum1 + arr[i];
//         else
//             sum2 = sum2 + arr[i];
//     }

// Console.WriteLine("Сумма элементов с нечетными номерами (нумерация начинается с нуля): {0} ", sum2);






// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76



int[] array = new int[8];
void newArray(int[]array)
{for (int i=0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-50,50);
    }}
void PrintArray(int[]array)
{for (int i=0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i < (array.Length)) Console.Write($", ");    }
    Console.WriteLine("  "); }
newArray(array);
PrintArray(array);
int max = array[0];
int min = array[0];
for (int i=0; i < array.Length; i++)
 {if (array[i] < min)
    { 
        min = array[i];
    }
    else if (array[i] > max)
    {
        max = array[i];   }}
Console.WriteLine("Разница между макс и мин элементами: " +(max - min));


