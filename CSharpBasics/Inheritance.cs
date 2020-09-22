using System;

public interface IShapeWithSides
{
    public double GetDiagonal();
}


public abstract class Shape
{
    // Define abstract members when you want derived classes to 
    //implement their own logic
    public abstract double GetArea();
    public abstract double GetCircumference();
    public virtual void Display()
    {
        Console.WriteLine("Displaying result for shape. ");   
    }
}

public class Rectangle : Shape, IShapeWithSides
{
    public Rectangle(double length, double breadth)
    {
        Length = length;
        Breadth = breadth;
    }
    public double Length { get; set; }
    public double Breadth { get; set; }
    public override double GetArea() => Length * Breadth;

    public override double GetCircumference() => 2 * (Length + Breadth);

    public override void Display()
    {
        Console.WriteLine($"Displaying results for Rectangele [{Length}X{Breadth}]:");
        Console.WriteLine($"Area: {this.GetArea()} square unit:");
        Console.WriteLine($"Circumferance: {this.GetCircumference()} unit.");
    }
    public double GetDiagonal() => Math.Sqrt(2 * (Length + Breadth));

}

public class Square : Rectangle
{
    public Square(double side) : base(side, side)
    {
        
    }
}

// public class Square : Shape, IShapeWithSides //this is how we inherit, using colon
// {
//     public Square(double side)
//     {
//         Side = side;
//     }
//     public double Side { get; set; }
//     public override double GetArea() => Side * Side;

//     public override double GetCircumference() => 4 * Side;
    
    

//     public double GetDiagonal() => Math.Sqrt(2 * Side * Side);
// }


public class Circle : Shape
{
    public double Radius { get; set; }
    public override double GetArea() => Math.PI * Radius * Radius;

    public override double GetCircumference() => 2 * Math.PI * Radius;

}

class A
{}

class B : A
{}

class C : B
{}

class D : A, IA, IB
{}

interface IA
{ }

interface IB
{ }