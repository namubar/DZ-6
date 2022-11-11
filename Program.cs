int[] array = new int[5];                  //Создание массива и заполнение случайными трехзначными числами;
int i;
void fillArray(int[] array)
{
    Random rnd = new Random();

    for (i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 1000);
        Console.Write(array[i] + " ");
    }
}
fillArray(array);
Console.WriteLine();

int sumDigit(int[] array)
{
    int count = 0;                               //Количество четных чисел;
    for (i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
int count = sumDigit(array);
Console.WriteLine(" Количество четных чисел в массиве: " + count);