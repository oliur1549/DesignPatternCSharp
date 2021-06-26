using System;

namespace OOP_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 3;
            Persons[] persons = new Persons[3];

            for (int i = 0; i < total; i++)
            {
                persons[i] = new Persons(Console.ReadLine());
            }

            for (int i = 0; i < total; i++)
            {
                Console.WriteLine(persons[i].ToString());
            }

        }
    }    
            
}
