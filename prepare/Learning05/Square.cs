public class Square : Shape
{
    private int _side;

    public int GetSides()
    {
        return _side;
    }

    public void SetSide(int sides)
    {
        _side = sides;
    }

    public override double GetArea()
    {
        return Math.Pow(_side, 2);
    }


}