using System;
using System.Collections.Generic;
using System.IO;

namespace GoalManagement
{
    public class GoalManager
    {
        private List<Goal> _goals;
        private int _score;
        private const string FileName = "goals.txt";

        public GoalManager()
        {
            _goals = new List<Goal>();
            _score = 0;
        }

        public void Start()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Create New Goal");
                Console.WriteLine("2. List Goals");
                Console.WriteLine("3. Save Goals");
                Console.WriteLine("4. Load Goals");
                Console.WriteLine("5. Record Event");
                Console.WriteLine("6. Quit");
                Console.Write("Select an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CreateGoal();
                        SaveGoals();
                        break;
                    case "2":
                        ListGoalDetails();
                        break;
                    case "3":
                        SaveGoals();
                        break;
                    case "4":
                        LoadGoals();
                        break;
                    case "5":
                        RecordEvent();
                        SaveGoals();
                        break;
                    case "6":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        public void ListGoalDetails()
        {
            Console.WriteLine($"\nScore: {_score}");
            foreach (var goal in _goals)
            {
                Console.WriteLine(goal.GetDetailsString());
            }
        }

        public void CreateGoal()
        {
            Console.WriteLine("\nChoose goal type:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            string typeChoice = Console.ReadLine();

            Console.Write("Enter goal name: ");
            string name = Console.ReadLine();
            Console.Write("Enter goal description: ");
            string description = Console.ReadLine();
            Console.Write("Enter goal points: ");
            int points = int.Parse(Console.ReadLine());

            switch (typeChoice)
            {
                case "1":
                    _goals.Add(new SimpleGoal(name, description, points));
                    break;
                case "2":
                    _goals.Add(new EternalGoal(name, description, points));
                    break;
                case "3":
                    Console.Write("Enter target amount: ");
                    int target = int.Parse(Console.ReadLine());
                    Console.Write("Enter bonus points: ");
                    int bonus = int.Parse(Console.ReadLine());
                    _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                    break;
                default:
                    Console.WriteLine("Invalid goal type.");
                    break;
            }
        }

        public void RecordEvent()
        {
            Console.WriteLine("\nSelect goal to record event:");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
            }
            int goalChoice = int.Parse(Console.ReadLine()) - 1;

            if (goalChoice >= 0 && goalChoice < _goals.Count)
            {
                _goals[goalChoice].RecordEvent();
                Console.WriteLine("Event recorded.");
                if (_goals[goalChoice].IsComplete())
                {
                    _score += _goals[goalChoice].Points;
                    Console.WriteLine("Goal completed! Points awarded.");
                }
            }
            else
            {
                Console.WriteLine("Invalid goal selection.");
            }
        }

        public void SaveGoals()
        {
            using (StreamWriter writer = new StreamWriter(FileName))
            {
                writer.WriteLine(_goals.Count);
                writer.WriteLine(_score);
                foreach (var goal in _goals)
                {
                    writer.WriteLine(goal.GetType().Name);
                    goal.Save(writer);
                }
            }
            Console.WriteLine("Goals saved.");
        }

        public void LoadGoals()
        {
            if (File.Exists(FileName))
            {
                using (StreamReader reader = new StreamReader(FileName))
                {
                    int goalCount = int.Parse(reader.ReadLine());
                    _score = int.Parse(reader.ReadLine());
                    _goals.Clear();
                    for (int i = 0; i < goalCount; i++)
                    {
                        string goalType = reader.ReadLine();
                        Goal goal = null;
                        switch (goalType)
                        {
                            case nameof(SimpleGoal):
                                goal = new SimpleGoal("", "", 0);
                                break;
                            case nameof(EternalGoal):
                                goal = new EternalGoal("", "", 0);
                                break;
                            case nameof(ChecklistGoal):
                                goal = new ChecklistGoal("", "", 0, 0, 0);
                                break;
                        }
                        goal.Load(reader);
                        _goals.Add(goal);
                    }
                }
                Console.WriteLine("Goals loaded.");
            }
            else
            {
                Console.WriteLine("No saved goals found.");
            }
        }
    }
}
