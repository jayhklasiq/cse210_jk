public class Circle : Shape
{
    private int _radius;

    public int GetRadius()
    {
        return _radius;
    }

    public void SetRadius(int radius)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }


}