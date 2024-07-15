using System.IO;

namespace GoalManagement
{
    public class EternalGoal : Goal
    {
        public EternalGoal(string name, string description, int points) : base(name, description, points) { }

        public override void RecordEvent()
        {
            _points += 100;
        }

        public override bool IsComplete()
        {
            return false;
        }

        public override string GetStringRepresentation()
        {
            return $"{_shortName}: {_description}";
        }

        public override void Save(StreamWriter writer)
        {
            base.Save(writer);
        }

        public override void Load(StreamReader reader)
        {
            base.Load(reader);
        }
    }
}
