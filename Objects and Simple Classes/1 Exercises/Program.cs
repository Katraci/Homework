using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Exercise> exercises = new List<Exercise>();
            string input= Console.ReadLine();
            while (input!= "go go go")
            {
                exercises.Add(CreatExercise(input));
                 input = Console.ReadLine();
            }
            PrintExercise(exercises);
        }

        static void PrintExercise(List<Exercise> exercises)
        {
            foreach (var item in exercises)
            {
                Console.WriteLine($"Exercises: {item.Topic}");
                Console.WriteLine($"Problems for exercises and homework for the \"{item.CourseName}\" course @ SoftUni.");
                Console.WriteLine($"Check your solutions here: {item.JudgeContestLink}");
                int token = 0;
                foreach (var part in item.Problems)
                {
                    token++;
                    Console.WriteLine($"{token}. {part}");
                }
            }
        }

        static Exercise CreatExercise(string input)
        {
            string[] curentInput = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            Exercise result = new Exercise {
                Topic = curentInput[0],
                CourseName=curentInput[1],
                JudgeContestLink=curentInput[2],
                Problems=curentInput[3].Split(new char[] { ',',' '}, StringSplitOptions.RemoveEmptyEntries).ToList()
            };
            return result;
        }

        class Exercise
        {
            public string Topic { get; set; }
            public string CourseName { get; set; }
            public string JudgeContestLink { get; set; }
            public List<string> Problems { get; set; }
        }
    }
}
