using System.IO;

namespace GoalManagement
{
    public class ChecklistGoal : Goal
    {
        private int _amountCompleted;
        private int _target;
        private int _bonus;

        public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
        {
            _amountCompleted = 0;
            _target = target;
            _bonus = bonus;
        }

        public override void RecordEvent()
        {
            _amountCompleted++;
            if (_amountCompleted >= _target)
            {
                _points += _bonus;
            }
        }

        public override bool IsComplete()
        {
            return _amountCompleted >= _target;
        }

        public override string GetStringRepresentation()
        {
            return $"{_shortName}: {_description} - {_amountCompleted}/{_target} completed";
        }

        public override string GetDetailsString()
        {
            return $"{_shortName}: {_description} - {_amountCompleted}/{_target} completed, {_points} points, {_bonus} bonus points";
        }

        public override void Save(StreamWriter writer)
        {
            base.Save(writer);
            writer.WriteLine(_amountCompleted);
            writer.WriteLine(_target);
            writer.WriteLine(_bonus);
        }

        public override void Load(StreamReader reader)
        {
            base.Load(reader);
            _amountCompleted = int.Parse(reader.ReadLine());
            _target = int.Parse(reader.ReadLine());
            _bonus = int.Parse(reader.ReadLine());
        }
    }
}
