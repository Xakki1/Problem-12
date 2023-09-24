int k, r, u, g, i;
string z = "", x = "", c = "";
Console.WriteLine("Введите число от 100 до 999");
k = Convert.ToInt32(Console.ReadLine());
r = k / 100;
u = k / 10 % 10;
g = k % 10;
i = k / 10;
if (k > 99 && k < 1000)
{
    switch (r)
    {
        case 1: z = "Сто"; break;
        case 2: z = "Двести"; break;
        case 3: z = "Триста"; break;
        case 4: z = "Четыреста"; break;
        case 5: z = "Пятьсот"; break;
        case 6: z = "Шестьсот"; break;
        case 7: z = "Семьсот"; break;
        case 8: z = "Восемьсот"; break;
        case 9: z = "Девятьсот"; break;
        default: break;
    }
    if (i < 20)
    {
        switch (u)
        {
            case 1: x = "один"; break;
            case 2: x = "два"; break;
            case 3: x = "три"; break;
            case 4: x = "четыре"; break;
            case 5: x = "пять"; break;
            case 6: x = "шесть"; break;
            case 7: x = "семь"; break;
            case 8: x = "восемь"; break;
            case 9: x = "девять"; break;
            case 10: x = "десять"; break;
            case 11: x = "одиннадцать"; break;
            case 12: x = "двенадцать"; break;
            case 13: x = "тринадцать"; break;
            case 14: x = "четырнадцать"; break;
            case 15: x = "пятнадцать"; break;
            case 16: x = "шестьнадцать"; break;
            case 17: x = "семьнадцать"; break;
            case 18: x = "восемьнадцать"; break;
            case 19: x = "девятнадцать"; break;
            default: break;
        }
        Console.WriteLine(z + " " + x);


    }
    else if (i > 19)
    {
        switch (u)
        {
            case 2: x = "двадцать"; break;
            case 3: x = "тридцать"; break;
            case 4: x = "сорок"; break;
            case 5: x = "пятьдесят"; break;
            case 6: x = "шестьдесят"; break;
            case 7: x = "семьдесят"; break;
            case 8: x = "восемьдесят"; break;
            case 9: x = "девяносто"; break;
            default: break;
        }
    }
    switch (g)
    {
        case 1: c = "один"; break;
        case 2: c = "два"; break;
        case 3: c = "три"; break;
        case 4: c = "четыре"; break;
        case 5: c = "пять"; break;
        case 6: c = "шесть"; break;
        case 7: c = "семь"; break;
        case 8: c = "восемь"; break;
        case 9: c = "девять"; break;
        default: break;
    }
    Console.WriteLine(z + " " + x + " " + c);
}
else
{
    Console.WriteLine("Неверное число");
}
Console.ReadKey();