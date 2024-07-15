using System.IO;

namespace GoalManagement
{
    public abstract class Goal
    {
        protected string _shortName;
        protected string _description;
        protected int _points;

        public Goal(string name, string description, int points)
        {
            _shortName = name;
            _description = description;
            _points = points;
        }

        public abstract void RecordEvent();
        public abstract bool IsComplete();
        public virtual string GetDetailsString()
        {
            return $"{_shortName}: {_description} ({_points} points)";
        }
        public abstract string GetStringRepresentation();

        public int Points => _points;

        public virtual void Save(StreamWriter writer)
        {
            writer.WriteLine(_shortName);
            writer.WriteLine(_description);
            writer.WriteLine(_points);
        }

        public virtual void Load(StreamReader reader)
        {
            _shortName = reader.ReadLine();
            _description = reader.ReadLine();
            _points = int.Parse(reader.ReadLine());
        }
    }
}
