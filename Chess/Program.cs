using System;
using System.Drawing;

namespace Chess
{
  internal class Program
  {
    private static void Main()
    {
      // Example 1 (reach desired position by one step)
      Execute(new Point(3, 3), new Point(2, 5), 1);

      //// Example 2 (reach desired position by two steps)
      Execute(new Point(3, 3), new Point(6, 2), 2);

      // Example 3 (reach desired position by three steps)
      Execute(new Point(3, 3), new Point(7, 4), 3); 

      Console.ReadLine();
    }

    private static void Execute(Point from, Point to, int testNumber)
    {
      Console.WriteLine("Test #{0}", testNumber);
      Console.WriteLine("From: {0}{1} To: {2}{3}", (Axis) from.X, from.Y, (Axis) to.X, to.Y);
      var k = new Knight();
      k.FindShortestPath(from, to);
      Console.WriteLine("{0}================================================================================", Environment.NewLine);
    }
  }
}
