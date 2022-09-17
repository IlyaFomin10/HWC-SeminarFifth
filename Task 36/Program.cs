// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] GetArray (int size, int min, int max)
{
    var array = new int [size];
    for (int i = 0; i <array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

int SumNotEven (int[] array)
{
        int result = 0;
        for (int i = 0; i < array.Length; i++)
    {
        if ((i+1) % 2 == 1)
        {
            result = result + array[i];
        }
    }
    return result;
}

Console.WriteLine("Введите колчество элементов массива: ");
int size = int.Parse(Console.ReadLine());
Console.WriteLine("Введите диапозон рандомных чисел, от числа: ");
int minrandom = int.Parse(Console.ReadLine());
Console.WriteLine("и так же до числа: ");
int maxrandom = int.Parse(Console.ReadLine());
int[] arr = GetArray(size, minrandom, maxrandom);
int sum = SumNotEven (arr);
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях равна {sum}");