namespace Task3Library
{
    public interface IShape
    {
        Point A { get; set; }
        Point B { get; set; }
        double Area();
        string ShapeInfo();
    }
}
