namespace BaseGeometricShapeApp
{
    public class BaseGeometricShape
    {
        public double Width { get; set; }
        public double Height { get; set; }
    public virtual double CalculateArea()
    {
        return 0;
    }
    }
// ---------------------------------------------

    public class Square : BaseGeometricShape
    {
        public override double CalculateArea()
        {
            return Width * Width;
        }
    }
// ------------------------------------------------

    public class Rectangle : BaseGeometricShape
    {
        public override double CalculateArea()
        {
            return Width * Height;
        }
    }
// ------------------------------------------------

    public class RightTriangle : BaseGeometricShape
    {
        public override double CalculateArea()
        {
            return (Width * Height) / 2 ;
        }
    }
}