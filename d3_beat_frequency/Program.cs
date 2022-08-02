//https://paiza.jp/works/mondai/drankfast/d3_beat_frequency
using System;


class Program
{
    static void Main()
    {
        var line = Console.ReadLine().Split();
        var f1 = int.Parse(line[0]);
        var f2 = int.Parse(line[1]);
        var ans = f1 - f2;
        Console.WriteLine(Math.Abs(ans));
    }
}