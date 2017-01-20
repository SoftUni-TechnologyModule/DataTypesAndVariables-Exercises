using System;

class TriplesOfLetters
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (char a = 'a'; a < 'a'+ n; a++)
        {
            for (char b = 'a'; b < 'a' + n; b++)
            {
                for (char c = 'a'; c < 'a' + n; c++)
                {
                    Console.WriteLine("{0}{1}{2}", a,b,c);
                }
            }
        }
    }
}

