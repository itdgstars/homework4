int cd(int number)
{
    
    int x = 0;
    int y = 0;
    while(number >= 1)
    { 
       
       x = number%10;
       number = number/10;
       y = y + x;
    }
    return y;
}

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int res2 = cd(a);
Console.WriteLine("Результат " + res2);
