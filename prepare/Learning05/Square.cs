using System.Reflection.Metadata.Ecma335;

public class Square : Shape
{

    private double _side;
    
    public Square(string color, float side) : base(color){

        _side = side;
    }

    public override double GetArea(){ 
        double area = _side * _side;
        return area;
    }
}