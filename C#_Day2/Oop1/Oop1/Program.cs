/*Write a program that demonstrates use of four basic principles of
object-oriented programming /Abstraction/, /Encapsulation/, /Inheritance/ and
/Polymorphism
*/

using System;

// Abstraction: Define an abstract class representing a Shape
abstract class Shape
{
    // Abstraction: Declare an abstract method
    public abstract void Draw();

    // Abstract property for Color
    public abstract string Color { get; set; }
}

// Inheritance: Circle inherits from Shape
class Circle : Shape
{
    // Encapsulation: Private fields for circle properties
    private int radius;
    private string color;

    // Constructor to initialize Circle
    public Circle(int radius, string color)
    {
        this.radius = radius;
        this.color = color;
    }

    // Encapsulation: using Public property to access color
    public override string Color
    {
        get { return color; }
        set { color = value; }
    }

    // Polymorphism: Override Draw method to draw Circle
    public override void Draw()
    {
        Console.WriteLine($"Drawing a {color} circle with radius {radius}");
    }
}

// Inheritance: Rectangle inherits from Shape
class Rectangle : Shape
{
    // Encapsulation: Private fields for rectangle properties
    private int width;
    private int height;
    private string color;

    // Constructor to initialize Rectangle
    public Rectangle(int width, int height)
    {
        this.width = width;
        this.height = height;
    }

    public override string Color
    {
        get { return color; }
        set { color = value; }
    }


    // Polymorphism: Override virtual Draw method in base class to draw Rectangle
    public override void Draw()
    {
        Console.WriteLine($"Drawing a rectangle with width {width} and height {height}");
    }
}

class Program
{
    static void Main()
    {
        // Polymorphism: Using shapes polymorphically
        // Base class reference pointing to a derived class object
        Shape shape1 = new Circle(6, "blue");
        Shape shape2 = new Rectangle(6, 8);

        // Encapsulation: Accessing properties
        //((Circle)shape1).Color = "red";

        shape1.Color = "red";
        shape1.Color = "blue";

        // Abstraction and Polymorphism: Iterating through shapes and calling Draw method
        shape1.Draw();
        shape2.Draw();

    }
}


/*
 *--Abstraction:
The Shape class is abstract and defines an abstract method Draw(), which is implemented differently in its derived classes (Circle and Rectangle).

*--Encapsulation:
Private fields (radius, color, width, height) are encapsulated within their respective classes (Circle and Rectangle).
Color property in Circle demonstrates encapsulation by providing controlled access to the color field.

*--Inheritance:
Circle and Rectangle inherit from the Shape class. They inherit the Draw() method and extend it with their specific implementations.

*--Polymorphism:
Circle and Rectangle override the Draw() method from the Shape class, allowing them to be used interchangeably through a Shape array (Shape[] shapes).
Polymorphism is demonstrated when calling shape.Draw() in the Main method, where the appropriate Draw() method for each shape (circle or rectangle) is called based on the actual object type.
 *
 *
*/
