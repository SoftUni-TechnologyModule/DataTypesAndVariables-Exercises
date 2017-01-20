using System;

class Elevator
{
    static void Main()
    {
        int peopleForOneCourse = int.Parse(Console.ReadLine());
        int elevatorCapacity = int.Parse(Console.ReadLine());

        double courses = (double)peopleForOneCourse / elevatorCapacity;

        Console.WriteLine(Math.Ceiling(courses));

    }
}

