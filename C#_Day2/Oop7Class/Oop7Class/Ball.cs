namespace Oop7Class;

public class Ball
{
    private int size;
    private Color color;
    private int throwCount;

    // Constructor
    public Ball(int size, Color color)
    {
        this.size = size;
        this.color = color;
        this.throwCount = 0;
    }

    // Pop method
    public void Pop()
    {
        this.size = 0;
    }

    // Throw method
    public void Throw()
    {
        if (size > 0)
        {
            throwCount++;
        }
    }

    // Method to get the throw count
    public int GetThrowCount()
    {
        return throwCount;
    }

    // Method to get the size
    public int Size
    {
        get { return size; }
    }

    // Method to get the color
    public Color Color
    {
        get { return color; }
    }

}
