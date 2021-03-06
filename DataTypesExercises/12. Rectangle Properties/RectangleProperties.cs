﻿using System;

class RectangleProperties
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double rectanglePerimeter = 2 * width + 2 * height;
        double rectangleArea = width * height;
        double rectangleDiagonal = Math.Sqrt(width * width + height * height);

        Console.WriteLine("{0}\n{1}\n{2}", rectanglePerimeter, rectangleArea, rectangleDiagonal);
    }
}

