namespace GoalManagement
{
    public class EternalGoal : Goal
    {
        public EternalGoal(string name, string description, int points)
            : base(name, description, points)
        {
        }

        public override void RecordEvent()
        {
            // This goal is eternal, so it can't be completed
        }

        public override bool IsComplete()
        {
            return false; // Eternal goals are never complete
        }

        public override string GetStringRepresentation()
        {
            return $"[Eternal Goal] {GetDetailsString()}";
        }
    }
}
