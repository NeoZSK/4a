
namespace GooseJump
{


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
