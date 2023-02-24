// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int size = 10;
int[] array = RandomNumbers(100);
int sumOddNumbers = 0;

int[] RandomNumbers (int inputArray)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(inputArray);
    }
    return result;
}

for(int i = 1; i < size; i++)
{
    sumOddNumbers+=array[i];
    i++;
}
Console.WriteLine($"Массив: [{String.Join(";", array)}]");
Console.WriteLine($"Сумма неченых чисел: {sumOddNumbers}");