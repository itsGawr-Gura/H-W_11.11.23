using System;

namespace H_W_11._11._23
{
    class Circle : Point
    {
        private double radius;
        public double GetArea()
        {
            return Math.PI * radius * radius;
        }
        public override void MoveHorizontal(int x)
        {
            Console.WriteLine($"Circle moved horizontally by {x}");
        }
    }
}
