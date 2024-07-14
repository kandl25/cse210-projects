using System;
using System.Collections.Generic;

namespace GoalManagement
{
    public class GoalManager
    {
        private List<Goal> _goals;
        private int _score;

        public GoalManager()
        {
            _goals = new List<Goal>();
            _score = 0;
        }

        public void Start()
        {
            // Example interaction with the GoalManager
            CreateGoal();
            DisplayPlayerInfo();
        }

        public void DisplayPlayerInfo()
        {
            Console.WriteLine($"Score: {_score}");
            foreach (var goal in _goals)
            {
                Console.WriteLine(goal.GetStringRepresentation());
            }
        }

        public void ListGoalNames()
        {
            foreach (var goal in _goals)
            {
                Console.WriteLine(goal.GetDetailsString());
            }
        }

        public void ListGoalDetails()
        {
            foreach (var goal in _goals)
            {
                Console.WriteLine(goal.GetDetailsString());
            }
        }

        public void CreateGoal()
        {
            // Simplified goal creation for demonstration
            _goals.Add(new SimpleGoal("Read a book", "Read a complete book", 100));
            _goals.Add(new EternalGoal("Exercise", "Exercise every day", 50));
            _goals.Add(new ChecklistGoal("Grocery Shopping", "Buy groceries", 200, 10, 20));
        }

        public void RecordEvent()
        {
            // Example of recording an event for the first goal
            _goals[0].RecordEvent();
        }

        public void SaveGoals()
        {
            // Serialization logic would go here
        }

        public void LoadGoals()
        {
            // Deserialization logic would go here
        }
    }
}
