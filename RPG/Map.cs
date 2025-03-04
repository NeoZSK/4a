
namespace RPG
{

    internal class Map
    {
        public const char WALL = '#';
        public const char GROUND = '.';

        private const string ROOT_DATA_PATH = @"C:\Users\User\Documents\data";
        private const string MAP_PATH = ROOT_DATA_PATH + @"\map.txt";

        private char[,] _board;

        public void Draw( Position playerPos)
        {
            for (int j = 0; j < _board.GetLength(1); j++)
            {
                for (int i = 0; i < _board.GetLength(0); i++)
                {
                    if (i == playerPos.X && j == playerPos.Y)
                    {
                        Console.Write(Player.ICON);
                    }
                    else
                    {
                        Console.Write(_board[i, j]);
                    }
                }
                Console.WriteLine();
            }
        }

        public void ImportBoard()
        {
            string[] lines = File.ReadAllLines(MAP_PATH);
            int height = lines.Length;
            int width = lines[0].Length;
            _board = new char[width, height];
            for (int i = 0; i < height; i++)
            {
                char[] linia = lines[i].ToCharArray();
                for (int j = 0; j < width; j++)
                {
                    _board[j, i] = linia[j];
                }
            }
        }

        public char GetBoardTile(Position pos)
        {
            if (pos.X < 0 || pos.X >= _board.GetLength(0)) return WALL;
            if (pos.Y < 0 || pos.Y >= _board.GetLength(1)) return WALL;
            return _board[pos.X, pos.Y];
        }

        public bool IsSteppable(char tile)
        {
            char[] steppableTiles = { GROUND };
            return steppableTiles.Contains(tile);
        }
    }
}
