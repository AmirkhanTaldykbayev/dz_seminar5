// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
//int size = 10; // Введение длины массивы вручную
// int size = new Random().Next(5,12); //еще один вариант получения рандомной длины массива
int[] array = EvenNumber(size, 100, 1000);
int count = 0;

int[] EvenNumber(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(100,1000);
    }
    return result;
}

for(int i = 0; i < size; i++)
{
    if (array[i] % 2 == 0)
    {
        count++;
    }
}

Console.WriteLine($"Массив: [{String.Join(";", array)}]");
Console.WriteLine($"Количество трехзначных чётных чисел в массиве: {count}");