// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
// Используйте NextDouble().

//P.S. Округлил до двух чисел после запятой, потому что при округлении до целых чисел не всегда правильно выдывал результат
//Например 97 - 17 показывал 89.

int size = 5;
Console.WriteLine("Введите максимально допустимое значение в элементе: ");
int multiplictaion = Convert.ToInt32(Console.ReadLine());
double[] array = RealNumbers(1);
double minValue = multiplictaion;
double maxValue = 0;

double[] RealNumbers(double inputArray)
{
    double[] result = new double[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = (new Random().NextDouble()) * multiplictaion;
    }
    return result;
}

for(int i = 0; i < size; i++)
{
    if(array[i] > maxValue)
    {
        maxValue = array[i];
    }
    else if (array[i] < minValue)
    {
        minValue = array[i];
    }
}

double diff = maxValue - minValue;

Console.WriteLine($"Массив: [{String.Join(" ; ", array)}]");
Console.WriteLine($"Значение максимального элемента массива: {maxValue:f2}");
Console.WriteLine($"Значение минимального элемента массива: {minValue:f2}");
Console.WriteLine($"Разница между максимальным и минимальным значением элементом массива: {diff:f2}");