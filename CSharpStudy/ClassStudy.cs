using System;
namespace CSharpStudy
{
    abstract class Shape
    {
        public abstract int GetArea();
    }

    class Square : Shape
    {
        private int _side;

        public Square(int n) => _side = n;

        // GetArea method is required to avoid a compile-time error.
        public override int GetArea() => _side * _side;
    }

    public class ClassStudy
    {
        public ClassStudy()
        {
        }

        public static void OverrideExample()
        {
            var sq = new Square(12);
            Console.WriteLine($"Area of the square = {sq.GetArea()}");
        }
    }
}
