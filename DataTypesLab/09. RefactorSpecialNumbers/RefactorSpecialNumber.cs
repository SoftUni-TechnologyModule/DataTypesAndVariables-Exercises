using System;

class RefactorSpecialNumber
{
    static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        int digit = 0;
        bool specialNumber = false;

        for (int ch = 1; ch <= inputNumber; ch++)
        {
            int sum = 0;
            digit = ch;
            while (ch > 0)
            {
                sum += ch % 10;
                ch = ch / 10;
            }
            specialNumber = (sum == 5) || (sum == 7) || (sum == 11);
            Console.WriteLine($"{digit} -> {specialNumber}");
            ch = digit;
        }
    }
}
