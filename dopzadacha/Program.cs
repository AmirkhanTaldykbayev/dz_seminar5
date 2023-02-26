// Доп. задачка:
// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.WriteLine("Укажите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = Generator(new Random().Next(1, 11));

int[] Generator(int inputArray)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(1, 11);
    }
    return result;
}

Console.WriteLine($"Случайно сгенерированный массив: [{String.Join(";", array)}]");

//Сгенерировал массив случайных чисел, теперь перехожу к решению задачи

int newSize = size / 2;
int[] newArray = ProductOfNumbers(array);

int[] ProductOfNumbers(int[] inputArray)
{
    int[] result = new int[newSize];
    for (int i = 0; i < newSize; i++)
    {
        result[i] = inputArray[i] * inputArray[size - 1 - i];
    }
    return result;
}

Console.WriteLine($"Произведение пар чисел первого и последнего элемента является: [{String.Join(";", newArray)}]");
