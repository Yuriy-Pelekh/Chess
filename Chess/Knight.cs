using System;
using System.Drawing;
using System.Linq;

namespace Chess
{
  public class Knight
  {
    public bool FindShortestPath(Point from, Point to)
    {
      var stepPoints = Step(from);

      if (stepPoints.Any(p => p.X == to.X && p.Y == to.Y))
      {
        Console.Write("{0}{1}", (Axis) to.X, to.Y);
        Console.Write(", {0}{1}", (Axis) from.X, from.Y);
        return true;
      }

      if (stepPoints.Any(point => FindShortestPath(point, to)))
      {
        Console.WriteLine(", {0}{1}", (Axis) from.X, from.Y);
        return false;
      }

      return false;
    }

    private Point[] Step(Point currentPosition)
    {
      var points = new[]
                     {
                       new Point(currentPosition.X + 1, currentPosition.Y - 2),
                       new Point(currentPosition.X + 2, currentPosition.Y - 1),
                       new Point(currentPosition.X + 2, currentPosition.Y + 1),
                       new Point(currentPosition.X + 1, currentPosition.Y + 2),
                       new Point(currentPosition.X - 1, currentPosition.Y + 2),
                       new Point(currentPosition.X - 2, currentPosition.Y + 1),
                       new Point(currentPosition.X - 2, currentPosition.Y - 1),
                       new Point(currentPosition.X - 1, currentPosition.Y - 2)
                     };

      return points.Where(ValidatePosition).ToArray();
    }

    private bool ValidatePosition(Point position)
    {
      return ValidateAxisPosition(position.X) && ValidateAxisPosition(position.Y);
    }

    private bool ValidateAxisPosition(int position)
    {
      return position >= 1 && position <= 8;
    }
  }
}
