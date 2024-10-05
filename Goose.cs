
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

        public void Jump(int power)
        {
            if (PosY != 0) return;
            VelocityY = power;
        }

        public void Move()
        {
            CalculateNextPosition();
        }

        private void CalculateNextPosition()
        {

            PosY += VelocityY;
            VelocityY--;

            if (PosY <= 0)
                VelocityY = 0;
        }


    }

    public struct Obstacle
    {
        public int Height { get; set; }
        public int PosX { get; set; }
    }

    internal class Map()
    {
        private int MapYPos { get; } = Console.WindowHeight / 2;
        public int Width { get; } = Console.WindowWidth;
        private const int OBSTACLE_HEIGHT_MAX = 1;
        private int CurrentX { get; set; } = 0;
        private Queue<Obstacle> Obstacles = new();

        public void Draw()
        {
            Console.SetCursorPosition(0, MapYPos);

            for (int i = 0; i < Width; i++)
                Console.Write("-");


            foreach (Obstacle o in Obstacles)
            {
                int h = 1;
                while (h <= o.Height)
                {
                    Console.SetCursorPosition(o.PosX - CurrentX, MapYPos - h);
                    Console.Write("#");
                    h++;
                }

            }
        }

        public void Move()
        {
            CurrentX++;
            if (Obstacles.Count > 0 && Obstacles.First().PosX <= CurrentX)
                Obstacles.Dequeue();

            var rand = new Random();
            if (rand.Next() % 5 == 0)
            {
                GenerateNextObstacle();
            }



        }

        private void GenerateNextObstacle()
        {
            var rand = new Random();
            int height = rand.Next() % OBSTACLE_HEIGHT_MAX + 1;
            var nextObstacle = new Obstacle
            {
                Height = height,
                PosX = CurrentX + Width - 1
            };

            Obstacles.Enqueue(nextObstacle);

        }
    }
}
