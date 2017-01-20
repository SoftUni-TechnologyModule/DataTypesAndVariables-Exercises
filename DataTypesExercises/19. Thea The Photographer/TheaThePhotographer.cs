using System;

class TheaThePhotographer
{
    static void Main()
    {
        ulong numberOfPictures = ulong.Parse(Console.ReadLine());
        ulong timeReauiredAllPictures = ulong.Parse(Console.ReadLine());
        ulong percentageOfGoodPictures = ulong.Parse(Console.ReadLine());
        ulong uploadTimeRequired = ulong.Parse(Console.ReadLine());

        decimal totalPictures = Math.Ceiling((numberOfPictures * percentageOfGoodPictures) / 100.0m);
        decimal sortingTimeneeded = numberOfPictures * timeReauiredAllPictures;
        decimal totalUploadTimeOfsortedPictures = totalPictures * uploadTimeRequired;

        decimal totalTimeRequired = sortingTimeneeded + totalUploadTimeOfsortedPictures;

        TimeSpan time = TimeSpan.FromSeconds((double)totalTimeRequired);

        Console.WriteLine("{0:D1}:{1:D2}:{2:D2}:{3:D2}", time.Days, time.Hours, time.Minutes, time.Seconds);
    }
}

