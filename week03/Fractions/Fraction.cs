public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom != 0 ? bottom : 1;
    }

    public void SetTop(int value)
    {
        _top = value;
    }

    public void SetBottom(int value)
    {
        if (value != 0)
            _bottom = value;
    }

    public int GetTop() => _top;
    public int GetBottom() => _bottom;

    public string ToFractionString() => $"{_top}/{_bottom}";
    public double ToDecimal() => (double)_top / _bottom;
}
