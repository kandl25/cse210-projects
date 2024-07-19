public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int duration, int laps)
        : base(date, duration)
    {
        this._laps = laps;
    }

    public override double GetDistance()
    {
        return (_laps * 50.0) / 1609.34;
    }

    public override double GetSpeed()
    {
        return GetDistance() / (GetDuration() / 60.0);
    }

    public override double GetPace()
    {
        return GetDuration() / GetDistance();
    }
}
