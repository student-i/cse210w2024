public class Circle : Shape
{
    private double _radius;

    public Circle(string color, float radius) : base(color){
        _radius = radius;
    }

    public override double GetArea(){
        double area = 3.14 * _radius * _radius;
        return area;
    }
}