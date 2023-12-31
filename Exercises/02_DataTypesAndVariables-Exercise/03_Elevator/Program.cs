﻿using System;

namespace _03_Elevator
{
    internal class Program
    {
        /*
         Calculate how many courses will be needed to elevate n persons by using an elevator of the capacity of p
        persons. The input holds two lines: the number of people n and the capacity p of the elevator

        17
        3
              6         5 courses * 3 people
                         + 1 course * 2 persons
        4
        5
              1         All the persons fit inside in the elevator.
                        Only one course is needed.
        10
        5
              2       2   courses * 5 people


        Hints
        • You should divide n by p. This gives you the number of full courses (e.g. 17 / 3 = 5).
        • If n does not divide p without a remainder, you will need one additional partially full course (e.g. 17 % 3 =
        2).
        • Another approach is to round up n / p to the nearest integer (ceiling), e.g. 17 / 3 = 5.67 → rounds up to 6.
        • Sample code for the round-up calculation:


         */
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling((double)numberOfPeople / capacity);
            if (numberOfPeople%capacity==2)
            {
                Console.WriteLine(courses);
            }
            else
            {
                Console.WriteLine(courses);
            }
        }
    }
}
