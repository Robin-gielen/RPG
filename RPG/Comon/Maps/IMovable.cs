using System;

namespace RPG.Comon
{
    public interface IMovable
    {
        int X { get; set; }
        int Y { get; set; }

        void Move(int x, int y);
        void MoveTo(int x, int y);
        int[] Position();
    }
}
