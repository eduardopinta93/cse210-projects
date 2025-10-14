using System;

public class Running : Activity
{
    
    private double _distance; 

    
    public Running(DateTime date, int minutes, double distance)
        : base(date, minutes) 
    {
        _distance = distance;
    }

    
    public double Distance
    {
        get { return _distance; }
        set { _distance = value; }
    }

    
    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        
        return (_distance / Minutes) * 60;
    }

    public override double GetPace()
    {
        
        return Minutes / _distance;
    }

   
}
