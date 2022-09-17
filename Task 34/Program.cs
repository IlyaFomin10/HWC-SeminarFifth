//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] GetArray (int size)
{
    var array = new int [size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

int AmountEvenNumber (int[] array)
{
        int result = 0;
        for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 == 0)
        {
            result = result +1;
        }
    }
    return result;
}

Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
int[] arr = GetArray(size);
int sum = AmountEvenNumber (arr);
Console.WriteLine($"Количество чётных чисел в массиве {sum}");
