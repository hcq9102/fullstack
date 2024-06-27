namespace Oop7Class;

public class Color
{
    private int red;
    private int green;
    private int blue;
    private int alpha;

    // Constructor with all parameters
    public Color(int red, int green, int blue, int alpha)
    {
        this.red = red;
        this.green = green;
        this.blue = blue;
        this.alpha = alpha;
    }

    // Constructor with default alpha value
    public Color(int red, int green, int blue) : this(red, green, blue, 255)
    {
    }

    // Getters and Setters
    public int Red
    {
        get { return red; }
        set { red = value; }
    }

    public int Green
    {
        get { return green; }
        set { green = value; }
    }

    public int Blue
    {
        get { return blue; }
        set { blue = value; }
    }

    public int Alpha
    {
        get { return alpha; }
        set { alpha = value; }
    }

    // Method to get grayscale value
    public int GetGrayscale()
    {
        return (red + green + blue) / 3;
    }

}
