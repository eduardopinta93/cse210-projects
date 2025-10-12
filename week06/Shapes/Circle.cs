class Circle : Shape
{
    private double _radius;
    double pi = Math.PI;

    public Circle(double radius, string color) : base(color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        double area = pi * (_radius * _radius);
        return area;
    }
}