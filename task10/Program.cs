Random rand = new Random();
int number = rand.Next(100, 1000);

Console.WriteLine($"Сгенерировлось случайное число {number}");

int digit3 = number % 10;
int digit1 = number / 100;

    Console.WriteLine($"Полученное число {digit1}{digit3}");
