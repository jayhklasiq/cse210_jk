public class Rectangle : Shape
{
    private int _width;
    private int _lenght;

    public int GetWidth()
    {
        return _width;
    }

    public void SetWidth(int width)
    {
        _width = width;
    }

    public int GetLenght()
    {
        return _lenght;
    }

    public void SetLenght(int lenght)
    {
        _lenght = lenght;
    }

    public override double GetArea()
    {
        return _lenght * _width;
    }
}