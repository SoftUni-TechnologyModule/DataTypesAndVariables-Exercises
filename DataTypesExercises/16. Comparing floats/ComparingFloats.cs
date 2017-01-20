using System;

class ComparingFloats
{
    static void Main()
    {
        double firstNum = double.Parse(Console.ReadLine());
        double secondNum = double.Parse(Console.ReadLine());

        double eps = 0.000001;
        double result = Math.Abs(firstNum - secondNum);
        bool equal = true;

        if (result > eps || firstNum == secondNum)
        {
            equal = false;
        }

        Console.WriteLine(equal);
    }
}

