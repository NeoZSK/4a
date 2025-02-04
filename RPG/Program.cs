const string ROOT_DATA_PATH = @"C:\Users\User\Documents\data";
const string MAP_PATH = ROOT_DATA_PATH + @"\map.txt";

const char PLAYER = '*';
const char WALL = '#';
const char GROUND = '.';

Position playerPos = new Position()
{
    X = 0,
    Y = 0
};
List<string> playerEq = new List<string>();   
char[,] map;

ImportBoard(out map);

while (true)
{
    Console.Clear();
    Draw(map, playerPos);
    Move(map, ref playerPos);
}


void Move(char[,] board, ref Position playerPos)
{
    var key = Console.ReadKey();
    Position nextPos = playerPos;

    switch (key.Key)
    {
        case ConsoleKey.UpArrow:
            nextPos.Y -= 1;
            break;
        case ConsoleKey.DownArrow:
            nextPos.Y += 1;
            break;
        case ConsoleKey.LeftArrow:
            nextPos.X -= 1;
            break;
        case ConsoleKey.RightArrow:
            nextPos.X += 1;
            break;
    }

    UpdatePosition(ref playerPos, nextPos, board)
}

void UpdatePosition(ref Position entityPos, Position nextPos, char[,] board)
{
    char tile = GetBoardTile(board, nextPos);
    if (IsSteppable(tile))
    {
        entityPos = nextPos;
    }
}

char GetBoardTile(char[,] board, Position pos)
{
    if (pos.X < 0 || pos.X >= board.GetLength(0)) return WALL;
    if (pos.Y < 0 || pos.Y >= board.GetLength(1)) return WALL;
    return board[pos.X, pos.Y];
}

bool IsSteppable(char tile)
{
    char[] steppableTiles = { GROUND,  };
    return steppableTiles.Contains(tile);
}
void Draw(char[,] map, Position playerPos)
{
    for (int j = 0; j < map.GetLength(1); j++)
    {
        for (int i = 0; i < map.GetLength(0); i++)
        {
            if (i == playerPos.X && j == playerPos.Y)
            {
                Console.Write(PLAYER);
            }
            else
            {
                Console.Write(map[i, j]);
            }
        }
        Console.WriteLine();
    }
}

void ImportBoard(out char[,] map)
{
    string[] lines = File.ReadAllLines(MAP_PATH);
    int height = lines.Length;
    int width = lines[0].Length;
    map = new char[width, height];
    for (int i = 0; i < height; i++)
    {
        char[] linia = lines[i].ToCharArray();
        for (int j = 0; j < width; j++)
        {
            map[j, i] = linia[j];
        }
    }
}

struct Position
{
    public int X;
    public int Y;
};
