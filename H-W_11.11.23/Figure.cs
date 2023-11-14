using System;

namespace H_W_11._11._23
{
    abstract class Figure : IFigure
    {
        protected string color;
        protected bool isVisible;
        public virtual void Show()
        {
            Console.WriteLine($"Figure: Color={color}, IsVisible={isVisible}");
        }
        public abstract void MoveHorizontal(int x);
        public abstract void MoveVertical(int y);
        public abstract void ChangeColor(string color);
    }
}
