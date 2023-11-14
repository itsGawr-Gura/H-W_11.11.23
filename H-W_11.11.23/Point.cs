using System;

namespace H_W_11._11._23
{
    class Point : Figure
    {
        public override void MoveHorizontal(int x)
        {
            Console.WriteLine($"Point moved horizontally by {x}");
        }
        public override void MoveVertical(int y)
        {
            Console.WriteLine($"Point moved vertically by {y}");
        }
        public override void ChangeColor(string color)
        {
            this.color = color;
        }
    }
}
