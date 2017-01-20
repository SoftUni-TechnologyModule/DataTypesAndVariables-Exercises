using System;

class SpecialNumbers
{
    static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        bool special = false;

        for (int i = 1; i <= inputNumber; i++)
        {
            int sum = 0;

            sum += i % 10;
            sum += i / 10;

            special = (sum == 5 || sum == 7 || sum == 11);

            Console.WriteLine("{0} -> {1}", i, special);
        }
    }
}

