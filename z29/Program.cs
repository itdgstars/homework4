int [] newmas (int sizemas)
{
    int [] mas = new int [sizemas]; // int (1) тип данных массива. random01array - имя массива. int(2) о типе массива. [размер массива]
    for (int i = 0; i < sizemas; i++)
    {
        mas[i] = new Random().Next(0,100);
    }
    return mas;
}

void masshow (int [] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write (array1[i] + ", ");
    }
}
Console.Write ("Введите количество элементовдля массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int [] array1 = newmas(N);
masshow(array1);