int NumberOne(int num, int index) // num - число, index - кол-во первых чисел которых мы хотим видеть
{
    while (num / Math.Pow(10, index) > 1)
    {
        num /= 10;
    }
    return num;
}

int number = int.Parse(Console.ReadLine()); // 11415411664
if (number < 0) number *=-1;
if (number > 99)
{
    int x = number % 100; // % - остаток от деления на 100
    int y = NumberOne (number, 2);
    if (x / 10 == y % 10 && x % 10 == y / 10)
    {
        System.Console.WriteLine( number + " Число полиндром");
    }
    else System.Console.WriteLine(number + " Число не полиндром");
} 

else if(number > 9)
{
    int x = number % 10;
    int y = NumberOne (number, 1);
}
else
{
    Console.WriteLine("Введите число больше 9");
}