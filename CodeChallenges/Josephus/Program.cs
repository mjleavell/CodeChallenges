using System;
using System.Collections.Generic;

namespace Josephus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of people");
            var numberOfPeople = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter killing interval");
            var killingInterval = Convert.ToInt32(Console.ReadLine());

            List<int> People = new List<int>(CreatePeople(numberOfPeople));

            LastPersonStanding(People, killingInterval);

            Console.ReadLine();
        }

        public static void LastPersonStanding(List<int> people, int killingInterval)
        {
            do
            {
                int killingCounter = 1;
                for (int i = 0; i < people.Count; i++)
                {
                    if (killingCounter == killingInterval)
                    {
                        Console.WriteLine($"killed person at {people[0]}");
                        people.RemoveAt(0);
                        killingCounter = 1;
                    }
                    else
                    {
                        people.Add(people[0]);
                        people.RemoveAt(0);
                        killingCounter++;
                        i--;
                    }
                }
            } while (people.Count > 1);
            Console.WriteLine($"{people[0]} is a survivor! She's gonna make it!");
        }

        public static List<int> CreatePeople(int numberOfPeople)
        {
            List<int> tempList = new List<int>();
            for (int i = 1; i <= numberOfPeople; i++)
            {
                tempList.Add(i);
            }
            return tempList;
        }
    }
}
