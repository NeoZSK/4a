
namespace GooseJump
{
    internal class Goose(int posX)
    {
        public int PosY { get; private set; } = 0;
        public int PosX { get; } = posX;

        private int VelocityY { get; set; } = 0;

        public void Draw()
        {
            var tempPos = Console.GetCursorPosition();
            Console.SetCursorPosition(PosX, Console.WindowHeight / 2 - 1 - PosY);
            Console.Write("*");
            Console.SetCursorPosition(tempPos.Left, tempPos.Top);
        }



    }

    internal class Map()
    {
        public int Width { get; }  = Console.WindowWidth;

        public void Draw()
        {
            Console.SetCursorPosition(0, Console.WindowHeight/2);

            for (int i = 0; i < Width; i++)
                Console.Write("-");
        }
    }
}
