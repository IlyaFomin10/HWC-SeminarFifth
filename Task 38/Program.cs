// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] GetArray (int size, int min, int max)
{
    var array = new double [size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble() + new Random().Next(min, max);
    }
    return array;
}

double DifferenceMaxMin (double[] array)
{
    double min = array [0];
    double max = array [0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] < min)
        {
            min = array [i];
        }
        if (array [i] > max)
        {
            max = array [i];
        }
    }
    double result = max - min;
    return result;
} 

Console.WriteLine("Введите колчество элементов массива: ");
int size = int.Parse(Console.ReadLine());
Console.WriteLine("Введите диапозон рандомных чисел, от числа: ");
int minrandom = int.Parse(Console.ReadLine());
Console.WriteLine("и так же до числа: ");
int maxrandom = int.Parse(Console.ReadLine());
double[] arr = GetArray(size, minrandom, maxrandom);
double result = DifferenceMaxMin (arr);
Console.WriteLine($"Разница между максимальным и минимальным элементов массива равна {result}");
