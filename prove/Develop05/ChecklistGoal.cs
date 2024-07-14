namespace GoalManagement
{
    public class ChecklistGoal : Goal
    {
        private int _amountCompleted;
        private int _target;
        private int _bonus;

        public ChecklistGoal(string name, string description, int points, int target, int bonus)
            : base(name, description, points)
        {
            _amountCompleted = 0;
            _target = target;
            _bonus = bonus;
        }

        public override void RecordEvent()
        {
            _amountCompleted++;
        }

        public override bool IsComplete()
        {
            return _amountCompleted >= _target;
        }

        public override string GetDetailsString()
        {
            return $"{base.GetDetailsString()}, Target: {_target}, Completed: {_amountCompleted}, Bonus: {_bonus}";
        }

        public override string GetStringRepresentation()
        {
            return $"[Checklist Goal] {GetDetailsString()}";
        }
    }
}
