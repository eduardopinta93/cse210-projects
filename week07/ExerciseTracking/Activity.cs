using System;

public abstract class Activity
{
    
    private DateTime _date;
    private int _minutes;

    
    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    
    public DateTime Date
    {
        get { return _date; }
        set { _date = value; }
    }

    public int Minutes
    {
        get { return _minutes; }
        set { _minutes = value; }
    }

    
    public abstract double GetDistance(); 
    public abstract double GetSpeed();    
    public abstract double GetPace();     

    
    public virtual string GetSummary()
{
    string activityName = this.GetType().Name; 
    double distance = GetDistance();
    double speed = GetSpeed();
    double pace = GetPace();

    
    string distanceUnit = "km";
    string speedUnit = "kph";
    string paceUnit = "min per km";

    return $"{Date.ToString("dd MMM yyyy")} {activityName} ({Minutes} min) - " +
           $"Distance: {distance:0.00} {distanceUnit}, " +
           $"Speed: {speed:0.00} {speedUnit}, " +
           $"Pace: {pace:0.00} {paceUnit}";
}

}
