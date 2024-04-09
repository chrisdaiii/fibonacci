// 前二十个数：1 1 2 3 5 8 13 21 34 55 89 144 233 377 610 987 1597 2574 4171 6745

using System.Diagnostics;

var stopwatch = Stopwatch.StartNew();

var number = Calc(45);

stopwatch.Stop();

Console.WriteLine($"Calc:  {number}, Elapsed: {stopwatch.Elapsed}");

stopwatch.Restart();

var number2 = Calc2(45);

stopwatch.Stop();

Console.WriteLine($"Calc2: {number2}, Elapsed: {stopwatch.Elapsed}");

Console.ReadLine();


// 递归法
long Calc(int number)
{
    if (number < 3)
    {
        return 1;
    }

    return Calc(number - 1) + Calc(number - 2);
}

long Calc2(int number)
{
    var list = new List<long>();

    for (var i = 0; i < number; i++)
    {
        if (i < 2)
        {
            list.Add(1);
        }
        else
        {
            list.Add(list[i - 1] + list[i - 2]);
        }
    }

    return list[number - 1];
}