using System;

class CenturiesToMinute
{
    static void Main()
    {
        ulong centuries = ulong.Parse(Console.ReadLine());
        ulong years = centuries * 100;
        ulong days = (ulong)(years * 365.2422);
        ulong hours = days * 24;
        ulong minutes = hours * 60;
        ulong second = minutes * 61;
        ulong milliSeconds = second * 1000;
        ulong microSeconds = milliSeconds * 1000;
        decimal nanoSeconds = microSeconds * 1000m;

        Console.WriteLine(centuries + " centuries = " + years + " years = " + days + " days = " + hours +
        " hours = " + minutes + " minutes = " + second + " seconds = " + milliSeconds +
        " milliseconds = " + microSeconds + " microseconds = " + nanoSeconds + " nanoseconds");
    }
}

