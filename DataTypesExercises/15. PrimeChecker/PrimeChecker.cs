using System;

class PrimeChecker
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        for (int digit = 2; digit <= number; digit++)
        {
            bool prime = true;
            for (int num = 2; num <= Math.Sqrt(digit); num++)
            {
                if (digit % num == 0)
                {
                    prime = false;
                    break;
                }
            }
            Console.WriteLine($"{digit} -> {prime}");
        }
    }
}

