﻿using System;

class RefactorVolumeOfPyramid
{
    static void Main()
    {
        Console.Write("Length: ");
        double lenght = double.Parse(Console.ReadLine()); ;
        Console.Write("Width: ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Height: ");
        double height = double.Parse(Console.ReadLine());       
        double volumeOfPyramid = (lenght * width * height) / 3.0;

        Console.WriteLine("Pyramid Volume: {0:F2}", volumeOfPyramid);
    }
}

