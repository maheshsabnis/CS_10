using System;
// namespace MyNamespace;
// implicit type inferance in C# 10
var process = () =>
{ // the client code
    GeometryArea obj = new GeometryArea(1000, 2000);
    return $"Area = {obj.CalculateArea()}";
};

Console.WriteLine(process());

GeometryArea obj2 = new GeometryArea(1000, 4000);
// using the Deconstruct

(decimal height, decimal width) = obj2;
Console.WriteLine($"Height = {height}");
Console.WriteLine($"Width = {width}");


class GeometryArea
{
    decimal Height;
    decimal Width;

    public GeometryArea(decimal height, decimal width)
    {
        Height = height;
        Width = width;            
    }

    public decimal CalculateArea()
    {
        return Height * Width;
    }
    /// <summary>
    /// The Deconstructor method
    /// </summary>
    public void Deconstruct(out decimal _Height, out decimal _Width)
    { 
        _Height = Height;
        _Width = Width;
    }
}


