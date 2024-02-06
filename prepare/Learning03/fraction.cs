
public class Fraction
{
    private int _top;
    private int _bottom;

    public void Fractions()
    {
        _top = 1;

        _bottom = 1;
    }

    public void WholeNumber(int WholeNumber)
    {

        _top = WholeNumber;

        _bottom = 1;

    }

    public void BothNumbers(int top, int bottom)
    {
        _top = top;

        _bottom = bottom;
    }

    public string GetFractionString()
    {

        return ($"{_top}/{_bottom}");
    }

    public double GetDecimalValue()
    {

        return ((double)_top / (double)_bottom);
    }
}
