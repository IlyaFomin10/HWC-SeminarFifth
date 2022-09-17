// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

int[] GetArray (int size, int min, int max)
{
    var array = new int [size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

int[] MetodCouples (int[] array)
{
    int[] newArray = null;
    if (array.Length % 2 == 0)
    {
        newArray = new int [array.Length/2];
        for (int i = 0; i < newArray.Length; i++)
        {
            newArray[i] = array[i] * array[array.Length -i - 1];
        }
    } 
    else
    {
        newArray = new int [array.Length/2 + 1];
        for (int i = 0; i < newArray.Length - 1; i++)
        {
            newArray[i] = array[i] * array[array.Length -i - 1];
        }
        newArray[newArray.Length] = array[array.Length / 2 + 1];
    }
    return newArray;
}

Console.WriteLine("Введите колчество элементов массива: ");
int size = int.Parse(Console.ReadLine());
Console.WriteLine("Введите диапозон рандомных чисел, от числа: ");
int minrandom = int.Parse(Console.ReadLine());
Console.WriteLine("и так же до числа: ");
int maxrandom = int.Parse(Console.ReadLine());
int[] arr = GetArray(size, minrandom, maxrandom);
int[] result = MetodCouples (arr);
Console.WriteLine("Произведение пар чисел в одномерном массиве равна: ");
for (int i = 0; i < result.Length; i++)
Console.Write($"{result[i]} ");
