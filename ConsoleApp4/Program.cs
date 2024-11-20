int lowerBound = -500;
int upperBound = 500;
Console.WriteLine($"Ищем трехзначные числа с четными сотнями в диапозоне от {lowerBound} {upperBound}");
for (int i = lowerBound; i <= upperBound; i++)
{
    if (i >= 100 && i <= 999)
    {
        if ((i / 100) % 2 == 0)
        {
            Console.WriteLine(i);
        }
    }
}