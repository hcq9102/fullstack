// See https://aka.ms/new-console-template for more information

using Oop7Class;

Color red = new Color(255, 0, 0);
Color green = new Color(0, 255, 0);
Color blue = new Color(0, 0, 255);

Ball ball1 = new Ball(10, red);
Ball ball2 = new Ball(15, green);
Ball ball3 = new Ball(20, blue);

ball1.Throw();
ball1.Throw();

ball2.Throw();

ball3.Pop();
ball3.Throw(); // shouldnot increment the throw count

Console.WriteLine("Ball 1 throw count: " + ball1.GetThrowCount());
Console.WriteLine("Ball 2 throw count: " + ball2.GetThrowCount());
Console.WriteLine("Ball 3 throw count: " + ball3.GetThrowCount());

//output
/*
 * Ball 1 throw count: 2
   Ball 2 throw count: 1
   Ball 3 throw count: 0

 */

