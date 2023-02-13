int ns(int a, int b)
{
   int res = 1;
    for (int i = 1; i <= b; i++)
    {
        res = res * a;
    }
    return res;
}

Console.Write("Введите первое число: ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b1 = Convert.ToInt32(Console.ReadLine());

int res2 = ns(a1, b1);
Console.Write("Результат " + res2);
