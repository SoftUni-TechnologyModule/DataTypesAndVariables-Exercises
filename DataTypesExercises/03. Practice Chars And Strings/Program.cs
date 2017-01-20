using System;

class Program
{
    static void Main()
    {
        //string string1 = "Software University";
        //char ch1 = 'B';
        //char ch2 = 'y';
        //char ch3 = 'e';
        //string string2 = "I love programming";

        //Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n", string1, ch1, ch2, ch3, string2);

        //int number = Convert.ToInt32(Console.ReadLine(), 16);

        //Console.WriteLine(number);

        //string hello = "Hello";
        //string word = "World";
        //object strConcate = hello + " " + word;
        //string together = (string)strConcate;
        //Console.WriteLine(together);

        //int a = 5;
        //int b = 10;
        //Console.WriteLine("Before:\na = {0}\nb = {1}", a, b);
        //int a1 = a;
        //a = b;
        //b = a1;
        //Console.WriteLine("After:\na = {0}\nb = {1}", a, b);

        //string firstName = "Amanda";
        //string lastName = "Jonson";
        //byte age = 27;
        //char gender = 'f';
        //long personalNumber = 8306112507;
        //int employeeNumber = 27563571;

        //Console.WriteLine("First name: {0}\nLast name: {1}\nAge: {2}\nGender: {3}\nPersonal ID: {4}\nUnique Employee number: {5}",
        //    firstName, lastName, age, gender, personalNumber, employeeNumber);

        string one = Console.ReadLine();
        string two = Console.ReadLine();
        string three = Console.ReadLine();

        string allCh = one + two + three;

        for (int i = allCh.Length - 1; i >= 0; i--)
        {
            Console.Write(allCh[i]);
        }
        Console.WriteLine();
    }
}

