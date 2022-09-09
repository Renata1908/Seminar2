Random rand = new Random();
int number = rand.Next(10, 100);

Console.WriteLine($"Сгенерировлось случайное число {number}");

int digit2 = number % 10;
int digit1 = number / 10;

if(digit1 > digit2)
{
    Console.WriteLine($"Первая цифра {digit1} больше второй {digit2}");

}
else if(digit1 < digit2)
{
    Console.WriteLine($"Вторая цифра {digit2} больше первой {digit1}");

}
else
{
        Console.WriteLine("Обе цифры равны");

}

