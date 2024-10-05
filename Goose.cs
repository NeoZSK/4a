
using System.Linq.Expressions;

namespace GooseJump
{
    public class Coords(int x = 0, int y = 0)
    {
        public int X { get; set; } = x;
        public int Y { get; set; } = y;


    }

    public abstract class Model
    {
        // X, Y from left, bottom of MAP
        public Coords Pos { get; set; } = new Coords();
        public int Width { get; protected set; } = 1;
        public int Height { get; protected set; } = 1;
        protected char Symbol { get; set; } = '#';

        public virtual void Draw(Coords mapPos)
        {
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    Console.SetCursorPosition(Pos.X + i + mapPos.X, mapPos.Y - (Pos.Y + j));
                    Console.Write(Symbol);
                }
            }

        }

    }

    public class Goose : Model
    {
        private int VelocityY { get; set; } = 0;

        public Goose(int posX)
        {
            Pos.X = posX;
            Pos.Y = 1;
            Symbol = '*';
        }


        public void Jump(int power)
        {
            if (Pos.Y != 1) return;
            VelocityY = power;
        }

        public void MoveLeft()
        {
            Pos.X--;
        }

        public void MoveRight()
        {
            Pos.X++;
        }

        public void CalculateNextPosition()
        {
            //PosX++;
            if (Pos.Y != 1 || VelocityY != 0)
            {

                Pos.Y += VelocityY;
                VelocityY--;

                if (Pos.Y <= 1)
                    VelocityY = 0;
            }
        }


    }

    internal class Obstacle : Model
    {
        public Obstacle(int h, int w, int x, int y)
        {
            Height = h;
            Width = w;
            Pos.X = x;
            Pos.Y = y;
        }
    }

    public class Map()
    {
        private Coords DrawingStart { get; set; } = new(0, Console.WindowHeight / 2);
        public int Width { get; } = Console.WindowWidth;

        private Queue<Obstacle> Obstacles = new();

        public void Setup()
        {

            for (int i = 0; i < 5; i++)
            {
                var nextObstacle = new Obstacle(2, 1, 50 + i * 15, 1);
                Obstacles.Enqueue(nextObstacle);
            }
        }

        public void Draw()
        {
            Console.SetCursorPosition(0, DrawingStart.Y);

            for (int i = 0; i < Width; i++)
                Console.Write("-");


            foreach (Obstacle o in Obstacles)
                o.Draw(DrawingStart);

        }

        public void Move()
        {
            //CurrentX++;
            //if (Obstacles.Count > 0 && Obstacles.First().PosX <= CurrentX)
            //    Obstacles.Dequeue();

        }

        private void GenerateNextObstacle()
        {

            var nextObstacle = new Obstacle(2, 1, DrawingStart.X + Width, 1);
            Obstacles.Enqueue(nextObstacle);

        }

        public Coords GetDrawingStartCoords() => DrawingStart;

    }
}
