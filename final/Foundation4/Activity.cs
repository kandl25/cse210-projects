public abstract class Activity
{
    private string _date;
    private int _duration;

    protected Activity(string date, int duration)
    {
        this._date = date;
        this._duration = duration;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_duration} min) - Distance: {GetDistance():F1} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }

    protected int GetDuration()
    {
        return _duration;
    }
}
