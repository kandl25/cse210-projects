using System.IO;

namespace GoalManagement
{
    public class SimpleGoal : Goal
    {
        private bool _isComplete;

        public SimpleGoal(string name, string description, int points) : base(name, description, points)
        {
            _isComplete = false;
        }

        public override void RecordEvent()
        {
            _isComplete = true;
        }

        public override bool IsComplete()
        {
            return _isComplete;
        }

        public override string GetStringRepresentation()
        {
            return $"{_shortName}: {_description} - {(IsComplete() ? "Completed" : "Not Completed")}";
        }

        public override void Save(StreamWriter writer)
        {
            base.Save(writer);
            writer.WriteLine(_isComplete);
        }

        public override void Load(StreamReader reader)
        {
            base.Load(reader);
            _isComplete = bool.Parse(reader.ReadLine());
        }
    }
}
